using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoundAndVision.API.Models.Forms;
using SoundAndVision.API.Models.Client.Entities;
using SoundAndVision.API.Repositories.Interfaces;
using System;
using Microsoft.AspNetCore.Authorization;
using SoundAndVision.API.Infrastructure.Interfaces;

namespace SoundAndVision.API.Controllers
{
    [Authorize]
    [Route("auth")]
    [ApiController]
    public class UserAuthenticationController : ControllerBase
    {
        private IUserAuthenticationRepository<User> _userAuthenticationService;
        private ITokenManager _tokenManager;
        private IImageUploader _imageUploader;

        public UserAuthenticationController(IUserAuthenticationRepository<User> userAuthenticationService, ITokenManager tokenManager, IImageUploader imageUploader)
        {
            _userAuthenticationService = userAuthenticationService;
            _tokenManager = tokenManager;
            _imageUploader = imageUploader;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody] UserRegisterForm userRegisterForm)
        {
            if ((userRegisterForm is null) || !ModelState.IsValid)
                throw new ArgumentException("Form is null or doesn't respect requirements!");

            try
            {
                //HttpRequest request = HttpContext.Request;
                ////IFormFile file = request.Form.Files[0];
                //IFormFile file = null;

                //userRegisterForm.Picture = _imageUploader.UploadImage(file, ImageFolder.Avatars).Result;

                User user = new User(userRegisterForm.Username, userRegisterForm.FirstName, userRegisterForm.LastName, userRegisterForm.Email, userRegisterForm.Password, userRegisterForm.Picture, userRegisterForm.Location, userRegisterForm.Bio);

                return Ok(_userAuthenticationService.Register(user));
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

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult SignIn([FromBody] UserSignInForm userSignInForm)
        {
            if ((userSignInForm is null) || !ModelState.IsValid)
                throw new ArgumentException("Form is null or doesn't respect requirements!");

            try
            {
                User user = _userAuthenticationService.SignIn(userSignInForm.Email, userSignInForm.Password);

                return Ok(_tokenManager.Authenticate(user));
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
