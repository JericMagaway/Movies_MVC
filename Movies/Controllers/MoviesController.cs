using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movies.Models;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {
        //
        // GET: /Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "WareHouse" };
            return View(movie);
        }


        public ActionResult Edit(int id)
        {

            return Content("id=" + id);

        }
	}
}