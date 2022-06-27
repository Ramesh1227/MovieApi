using Microsoft.AspNetCore.Mvc;
using MovieinformationService.Domain;
using MovieinformationService.Domain.Services.Interfaces;
using MovieInformationService.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieInformationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieInformationController : ControllerBase
    {
        public  readonly IMovieInfoService _movieInfoService;
        public MovieInformationController(IMovieInfoService movieInfoService)
        {
            _movieInfoService = movieInfoService;
        }

        // GET: api/<ValuesController>
        [HttpGet("GetAllMovieInfomation")]
        public async Task<IActionResult> GetAllMovieInfomation()
        {
            var result = await _movieInfoService.GetAllMovieInformation();
            return Ok(result);
        }

        // POST api/<ValuesController>
        [HttpPost("CreateMovieInformation")]
        public async Task<IActionResult> CreateMovieInformation([FromBody] MovieInformationCreateRequest request)
        {
            var response = await _movieInfoService.CreateMovieInformation(request);

            return Ok(response);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("EditMovieInformation")]
        public async Task<IActionResult> EditMovieInformation(MovieInformationEditRequest request)
        {
            var response = await _movieInfoService.EditMovieInformation(request);

            return Ok(response);
        }
    }
}
