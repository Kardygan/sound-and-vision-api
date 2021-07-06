using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoundAndVision.API.Models.Client.Entities;
using SoundAndVision.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoundAndVision.API.Controllers
{
    [Authorize]
    [Route("albums")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private IAlbumRepository<Album, AlbumFull> _albumService;

        public AlbumController(IAlbumRepository<Album, AlbumFull> albumService)
        {
            _albumService = albumService;
        }

        [AllowAnonymous]
        [HttpGet()]
        public IActionResult Get()
        {
            try
            {
                return Ok(_albumService.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_albumService.Get(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
