using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        //
        // GET: /Customers/
        public ActionResult Index()
        {
            var customers = _context.Cutomers.ToList();
            return View(customers);
        }

        public ActionResult Detail(int id)
        {
            var customer = _context.Cutomers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
       

        
	}
}