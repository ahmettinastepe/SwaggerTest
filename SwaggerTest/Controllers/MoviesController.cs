using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaggerTest.MockData;
using SwaggerTest.Model;

namespace SwaggerTest.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        /// <summary>
        /// Get All Movie List
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Movie> GetAll()
        {
            return Movies.GetMovies();
        }


        /// <summary>
        /// Get Movie Id
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /Movies/1
        ///     {
        ///        "id": 1,
        ///        "name": "string",
        ///        "description": "string",
        ///        "imdb": 0
        ///     }
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>Single Movie</returns>
        /// <response code="200">Returns a movie</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public Movie GetById(int id)
        {
            var movie = Movies.GetMovies().Where(x => x.Id == id).FirstOrDefault();
            return movie;
        }
    }
}