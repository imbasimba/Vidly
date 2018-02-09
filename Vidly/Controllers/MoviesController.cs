using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;


namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            return View(GetMovies());
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer{ Name = "Customer 1"},
                new Customer{ Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var identifiedMovie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (identifiedMovie == null)
            {
                return HttpNotFound();
            }
            return View(identifiedMovie);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }

    }
}