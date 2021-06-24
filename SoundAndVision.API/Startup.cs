using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using GE = SoundAndVision.API.Models.Global.Entities;
using GR = SoundAndVision.API.Models.Global.Repositories;
using CE = SoundAndVision.API.Models.Client.Entities;
using CR = SoundAndVision.API.Models.Client.Repositories;
using SoundAndVision.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Tools.Connection.Database;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using SoundAndVision.API.Infrastructure;
using SoundAndVision.API.Infrastructure.Interfaces;

namespace SoundAndVision.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SoundAndVision.API", Version = "v1" });
            });

            // Personal services.
            services.AddSingleton(sp => new Connection(SqlClientFactory.Instance, @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SoundAndVisionDB;Integrated Security=True;"));
            services.AddSingleton<ITokenManager, TokenManager>();

            services.AddSingleton<IUserAuthenticationRepository<GE.User>, GR.UserAuthenticationRepository>();
            services.AddSingleton<IUserAuthenticationRepository<CE.User>, CR.UserAuthenticationRepository>();

            // Roles.
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy => policy.RequireRole("Admin"));
                options.AddPolicy("Moderator", policy => policy.RequireRole("Moderator", "Admin"));
                options.AddPolicy("Contributor", policy => policy.RequireRole("Contributor", "Moderator", "Admin"));
                options.AddPolicy("User", policy => policy.RequireRole("User", "Contributor", "Moderator", "Admin"));
            }
            );

            // Authentication rules.
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(option =>
                {
                    option.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                    {
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(TokenManager.secretKey)),
                        ValidateIssuer = true,
                        ValidIssuer = TokenManager.issuer,
                        ValidateAudience = true,
                        ValidAudience = TokenManager.audience
                    };
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SoundAndVision.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(x => x.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
