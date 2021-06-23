using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoundAndVision.API.Models.Entities;
using CE = SoundAndVision.API.Models.Client.Entities;
using SoundAndVision.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoundAndVision.API.Models.Entities.Forms;
using System.Data.SqlClient;
using SoundAndVision.API.Models.Mappers;

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
            if ((userRegisterForm is null) || !ModelState.IsValid)
                throw new ArgumentException("Form is null or doesn't respect requirements!");

            try
            {
                CE.User user = new CE.User(userRegisterForm.Username, userRegisterForm.FirstName, userRegisterForm.LastName, userRegisterForm.Email, userRegisterForm.Password, userRegisterForm.Picture, userRegisterForm.Location, userRegisterForm.Bio);

                return Ok(_userAuthenticationRepositoryClient.Register(user));
            }
            catch (ArgumentException aex)
            {
                return BadRequest(aex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]
        public IActionResult SignIn([FromBody] UserSignInForm userSignInForm)
        {
            if ((userSignInForm is null) || !ModelState.IsValid)
                throw new ArgumentException("Form is null or doesn't respect requirements!");

            try
            {
                User user = _userAuthenticationRepositoryClient.SignIn(userSignInForm.Email, userSignInForm.Password).ToUserAPI();

                return Ok(user);
            }
            catch (ArgumentException aex)
            {
                return BadRequest(aex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
