using Microsoft.AspNetCore.Mvc;
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
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
