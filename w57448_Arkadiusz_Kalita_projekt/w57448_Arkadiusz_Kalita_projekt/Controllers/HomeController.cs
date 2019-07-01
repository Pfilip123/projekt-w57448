using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace w57448_Arkadiusz_Kalita_projekt.Controllers
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
        public ActionResult Aplikacja()
        {
            return View();
        }
        public ActionResult O_nas()
        {
            return View();
        }
        public ActionResult Oferta()
        {
            return View();
        }
        public ActionResult Edycja_oferty()
        {
            return View();
        }
        public ActionResult Dostepnosc()
        {
            return View();
        }
        public ActionResult Umawianie_wizyt()
        {
            return View();
        }
    }
}