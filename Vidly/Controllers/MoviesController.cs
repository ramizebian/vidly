using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Vidly.Models;
using Vidly.ViewModels;
using Action = Antlr.Runtime.Misc.Action;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };


            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(ViewModel);
            //return Content("Hello there, the movie name is: " + movies.Name);
            //return RedirectToAction("Index", "Home", new{page=1, sortby="Name"});
        }

        // GET: Movies/Edit/{id}
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);

            //if (!pageIndex.HasValue)
            //    pageIndex = 1;
            //if (sortBy.IsNullOrWhiteSpace())
            //    sortBy = "Name";
            //return Content(string.Format("pageIndex={0}&sortby={1}", pageIndex, sortBy));
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
              {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }


        // GET: ByReleaseDate
        [Route("Movies/Released/{year}/{month:range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }


    }
}