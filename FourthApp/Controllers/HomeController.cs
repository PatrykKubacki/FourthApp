using System;
using System.Threading;
using System.Web.Mvc;
using FourthApp.Models;

namespace FourthApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            if(!Request.IsAjaxRequest())
                return Content($"Imie: {user.FirstName}, Nazwisko: {user.LastName}, Wiek: {user.Age}");

            return Json(user);

        }

        public string GetTime()
        {
            Thread.Sleep(2000);
            return DateTime.Now.ToLongTimeString();
        }
    }
}