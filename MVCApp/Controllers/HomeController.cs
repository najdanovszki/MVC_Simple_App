using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;
using static DataLibrary.Logic.PeopleLogic;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult People()
        {
            ViewBag.Message = "People";

            return View();
        }

        [HttpPost]
        public ActionResult People(PeopleModel people)
        {
            //ViewBag.Message = "People";
            int RecordsCreated = CreatePaople(people.FirstName, people.LastName, people.BirthDate);
            return RedirectToAction("Index");

            //return View();
        }
    }
}