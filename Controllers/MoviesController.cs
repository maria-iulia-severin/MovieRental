using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRental.Models;
using MovieRental.ViewModels;

namespace MovieRental.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Srak" };
            var customers = new List<Customer>
            { 
                new Customer { Name = "Cust 1" },
                new Customer { Name = "Cust 2" }
            };

            var viewModel = new RandomMovieViewModel
            { 
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
        /*    public ActionResult Edit(int id)
          {
              return Content("id=" + id);
          }
          //movies - unde avem ? inseamna aca e optional
        public ActionResult Index(int? pageIndex, string sortBy)
          {
              if (!pageIndex.HasValue)
                  pageIndex = 1;
              if (String.IsNullOrWhiteSpace(sortBy))
                  sortBy = "Name";
              return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
          }*/

        //varianta mai usoara pt routing e sa adaug aici calea pe care o are, asa nu trebuie sa merg in routeconfig si sa modific 
        //de fiecare data, am adaugat regex ca sa fie constrangerea

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}