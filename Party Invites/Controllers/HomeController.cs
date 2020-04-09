using Microsoft.AspNetCore.Mvc;
using Party_Invites.Models;
using System;
using System.Linq;

namespace Party_Invites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;

            ViewBag.Greeting = hour < 17 ? "Dzień dobry" : "Dobry wieczur";

            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse model)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(model);
                return View("Thanks", model);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            var guests = Repository.Responses
                .Where(x => x.WillAttend == true)
                .ToList();

            return View(guests);
        }
    }
}
