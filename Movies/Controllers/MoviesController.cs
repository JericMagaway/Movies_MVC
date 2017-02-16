using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movies.Models;
using Movies.ViewModel;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {
        //
        // GET: /Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "WareHouse" };
            var customers = new List<Customer>

            {
                new Customer  { Name = "Customer 1"},
                new Customer  { Name = "Customer 2"}

            };

            var viewModel = new RandomMovieViewModel

            {
               Movie = movie,
               Customers = customers

            };

            return View(viewModel);
       
        }






        /*
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //Movies/Index?pageIndex=2&sortBy=named 
        public ActionResult Index(int?  pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy ));
        }*/




        public List<Customer> Customers { get; set; }
    }
}