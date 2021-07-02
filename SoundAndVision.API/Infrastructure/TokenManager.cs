using Microsoft.IdentityModel.Tokens;
using SoundAndVision.API.Infrastructure.Interfaces;
using SoundAndVision.API.Models.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SoundAndVision.API.Infrastructure
{
    public class TokenManager : ITokenManager
    {
        public static string secretKey = @"/rFA4_Xx4<~Q.z[ZqbFYKg}f5k$aU5WN&&VS]]B>K-jC/?Ab$mrC[9NjP_GX*=6nMb-Kh9/wU`8(U(L)gY&?ZYGBn$-)<g}+n32wffZtt.;/7g`^'zC-\eVSCh6rvBds";
        public static string issuer = "localhost:44349"; // API provider.
        public static string audience = "localhost:4200"; // API consumer.

        public User Authenticate(User user)
        {
            if (user.Email is null)
                throw new ArgumentNullException();

            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);

            Claim[] claims = new[]
            {
                new Claim("UserId", user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
            };

            switch (user.RoleId)
            {
                case 1:
                    claims.Append(new Claim(ClaimTypes.Role, "Admin"));
                    break;
                case 2:
                    claims.Append(new Claim(ClaimTypes.Role, "Moderator"));
                    break;
                case 3:
                    claims.Append(new Claim(ClaimTypes.Role, "Contributor"));
                    break;
                case 4:
                    claims.Append(new Claim(ClaimTypes.Role, "User"));
                    break;
            }

            JwtSecurityToken token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials,
                issuer: issuer,
                audience: audience
                );

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            user.Token = handler.WriteToken(token);

            return user;
        }
    }
}
