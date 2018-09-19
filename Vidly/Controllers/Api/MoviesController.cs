using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;
using Vidly.Dtos;
using AutoMapper;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/movies
          public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }
        // GET/api/movies/1
        public Movie GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
                throw new Exception();

            return movie;
        }
        // POST /api/movies
        [HttpPost]
        public Movie CreateMovie(Movie movie)
        {
            if (!ModelState.IsValid)
                throw new Exception("Hej");

            _context.Movies.Add(movie);
            _context.SaveChanges();
            int id = movie.Id;
            return _context.Movies.SingleOrDefault(m => m.Id == id);
        }
        [HttpPut]
        public void UpdateMovie(int id, Movie movie)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            //var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);
          //  if (movieInDb == null)
             //   throw new HttpResponseException(HttpStatusCode.NotFound);
            //Mapper.Map(customerDto, customerInDb);
           // _context.Movies.SingleOrDefault(m => m.Id == id) = movie;
            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();
        }





    }
}
