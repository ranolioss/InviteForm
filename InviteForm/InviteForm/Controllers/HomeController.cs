using InviteForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InviteForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good Evening";
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
        public ViewResult EnrollNow()
        {
            return View();
            //return View("Thanks" , response);  
        }
        [HttpPost]
        public ViewResult EnrollNow(Response response)
       
            {
                if (ModelState.IsValid)
                {

                    return View("Thanks", response);
                }
                else
                    return View();
            }
        }
}