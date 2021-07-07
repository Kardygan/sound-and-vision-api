using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoundAndVision.API.Infrastructure.Interfaces;
using SoundAndVision.API.Models.Client.Entities;
using SoundAndVision.API.Models.Forms;
using SoundAndVision.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoundAndVision.API.Controllers
{
    [Authorize]
    [Route("artists")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private IArtistRepository<Artist> _artistService;
        private IImageUploader _imageUploader;

        public ArtistController(IArtistRepository<Artist> artistService, IImageUploader imageUploader)
        {
            _artistService = artistService;
            _imageUploader = imageUploader;
        }

        [AllowAnonymous]
        [HttpGet()]
        public IActionResult Get()
        {
            try
            {
                return Ok(_artistService.Get());
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
                return Ok(_artistService.Get(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost()]
        public IActionResult Add([FromBody] ArtistAddForm artistAddForm)
        {
            if ((artistAddForm is null) || !ModelState.IsValid)
                throw new ArgumentException("Form is null or doesn't respect requirements!");

            try
            {
                //HttpRequest request = HttpContext.Request;
                ////IFormFile file = request.Form.Files[0];
                //IFormFile file = null;

                //artistAddForm.Picture = _imageUploader.UploadImage(file, ImageFolder.Artists).Result;

                Artist artist = new Artist(artistAddForm.Name, artistAddForm.Picture, artistAddForm.Alias, artistAddForm.StartDate, artistAddForm.EndDate, artistAddForm.Description);

                return Ok(_artistService.Add(artist));
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
        [HttpPost("upfile")]
        public async Task<IActionResult> PostImg()
        {
           string url = await _imageUploader.UploadImage(HttpContext.Request, ImageFolder.Artists);
            return this.StatusCode(200, url);
        }
    }
}
