using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRental.Controllers
{
    public class CustomersController : Controller
    {
        //avem nevoie de DbContext ca sa putem folosi baza de date

        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        //ApplicationDbContext este un disposable object si trebuie sa scapam de el corect
        //adica override metoda Dispose a clasei Base
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ActionResult Index()
        {
            //prin asta eu am acces la tot DbSet-ul Customers din baza de date
            //acest query este de fapt executat doar cand mergem cu foreach prin tot dbSet-ul, adica in View-ul pt Customer
            //var customers = _context.Customers;
            //daca as vrea sa execut query-ul aici, as putea sa fac: 
            var customers = _context.Customers.ToList();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
    }
}