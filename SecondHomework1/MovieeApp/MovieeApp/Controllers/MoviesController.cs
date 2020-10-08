using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieeApp.Models;
using Newtonsoft.Json;

namespace MovieeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Movie>> GetAllMovies()
        {
            var listOfAllMovies = StaticDb.Movies.ToList();
            if (listOfAllMovies.Count == 0)
                return NoContent();
            return StatusCode(StatusCodes.Status200OK, listOfAllMovies);

        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovie(int id)
        {
            var movie = StaticDb.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return StatusCode(StatusCodes.Status404NotFound, new Movie());

            return StatusCode(StatusCodes.Status200OK, movie);
        }

        [HttpPost]
        public ActionResult<List<Movie>> CreateMovie([FromBody] Movie movie)
        {
            try
            {
                StaticDb.Movies.Add(movie);
                return StatusCode(StatusCodes.Status201Created, "Movie successfully created");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        // Add GET method that returns movie by specific name using query parametar
        // https://localhost:44330/api/movies/get-movie-by-name?name=Ten%20things%20I%20hate%20about%20you (try this later)
        [HttpGet("get-movie-by-name")]
        public ActionResult<Movie> GetMovieByName([FromQuery] string name)
        {
            var movie = StaticDb.Movies.SingleOrDefault(m => m.Name == name);

            if (movie == null)
                return StatusCode(StatusCodes.Status404NotFound, new Movie());

            return StatusCode(StatusCodes.Status200OK, movie);
        }

        //[HttpPut]
        //public ActionResult<Movie> UpdateMovieArtist([FromBody] string nameOfArtist, [FromRoute] int id, [FromQuery] string nameOfMovie ) 
        //{
        //    var movie = StaticDb.Movies.SingleOrDefault(x => x.Name == nameOfMovie);

        //    if (movie == null)
        //        return StatusCode(StatusCodes.Status404NotFound, new Movie());

        //    var artist = movie.Artists.SingleOrDefault(x => x.Id == id);
        //    var indexOfArtist = movie.Artists.IndexOf(artist);

        //    if (artist == null)
        //        return StatusCode(StatusCodes.Status404NotFound, new Movie());

        //    if (indexOfArtist < 0)
        //        return StatusCode(StatusCodes.Status404NotFound, new Movie());

        //    artist.FirstName = nameOfArtist;

        //    movie.Artists.RemoveAt(indexOfArtist);
        //    movie.Artists.Add(artist);

        //    return StatusCode(StatusCodes.Status200OK, movie);
        //}
    }
}

