using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoundAndVision.API.Infrastructure.Interfaces;
using SoundAndVision.API.Repositories.Interfaces;
using CE = SoundAndVision.API.Models.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoundAndVision.API.Controllers
{
    [Authorize]
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository<CE.User> _userRepositoryClient;

        public UserController(IUserRepository<CE.User> userRepositoryClient)
        {
            _userRepositoryClient = userRepositoryClient;
        }

        [Authorize("User")]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_userRepositoryClient.Get(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize("Moderator")]
        [HttpGet()]
        public IActionResult Get()
        {
            try
            {
                return Ok(_userRepositoryClient.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
