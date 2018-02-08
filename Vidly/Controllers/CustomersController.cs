using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;


namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var viewModel = new CustomersViewModel
            {
                Customers = GetCustomers(),
                Title = "Customers"
            };
            
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            Customer identifiedCustomer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if(identifiedCustomer == null)
            {
                return HttpNotFound();
            }
            return View(new DetailsViewModel
            {
                Customer = identifiedCustomer
            });
        }

        private List<Customer> GetCustomers()
        {
            return _context.Customers.Include(c => c.MembershipType).ToList();
        }

    }
}