using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoundAndVision.API.Models.Entities;
using CE = SoundAndVision.API.Models.Client.Entities;
using SoundAndVision.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoundAndVision.API.Models.Forms;

namespace SoundAndVision.API.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class UserAuthenticationController : ControllerBase
    {
        private IUserAuthenticationRepository<CE.User> _userAuthenticationRepositoryClient;

        public UserAuthenticationController(IUserAuthenticationRepository<CE.User> userAuthenticationRepositoryClient)
        {
            _userAuthenticationRepositoryClient = userAuthenticationRepositoryClient;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] UserRegisterForm userRegisterForm)
        {
            CE.User user = new CE.User(userRegisterForm.Username, userRegisterForm.FirstName, userRegisterForm.LastName, userRegisterForm.Email, userRegisterForm.Password, userRegisterForm.Picture, userRegisterForm.Location, userRegisterForm.Bio);

            if (_repository.Register(user))
                return Ok();

            return BadRequest();
        }
    }
}
