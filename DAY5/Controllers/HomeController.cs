using DAY5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAY5.Controllers
{
    public class HomeController : Controller
    {
        List<Person> people = new List<Person>();

        [HttpGet]
        public ActionResult Index()
        {
            Person person = new Person();
            ViewBag.People = people;
            return View(person);
        }

        public ActionResult About(Person person)
        {
            if (!ModelState.IsValid)
                return View(person);
            people.Add(person);
            return View("About", person);


        }
    }
}