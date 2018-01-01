using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mubee.Models;
using System.Data.Entity;

namespace Mubee.Controllers
{
    public class CustomersController : Controller
    {
        //Used for Database connection
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        //public ViewResult Index()
        //{

        //    var customers = _context.Customers.Include(c => c.MembershipType).ToList();

        //    return View(customers);
        //}

        //public ActionResult Details(int id)
        //{
        //    var customer = _context.Customers.Include(m => m.MembershipType)
        //        .SingleOrDefault(c => c.Id == id);
        //    if (customer == null)   
        //        return HttpNotFound();

        //    return View(customer);
        //}

        // Not being used anymore, here as an example
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {

                new Customer { Id = 1, Name = "Douglas Rodriguez" },
                new Customer { Id = 2, Name = "Gretchen Betancourt" }
            };
        }
    }
}