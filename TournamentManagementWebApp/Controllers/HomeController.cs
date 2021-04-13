using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TournamentManagementWebApp.DAL;

namespace TournamentManagementWebApp.Controllers
{
    public class HomeController : Controller
    {
        public DataContext context { get; set; }

        public HomeController()
        {
            context = new DataContext();
        }
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

        public ActionResult Teams()
        {
            var teams = context.Teams.ToList();
            return View(teams);
        }
    }
}