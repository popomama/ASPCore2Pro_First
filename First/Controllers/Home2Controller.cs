using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.Models;
using Microsoft.AspNetCore.Mvc;

namespace First.Controllers
{
    public class Home2Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Greeting = DateTime.Now.ToLongTimeString();
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        public ViewResult RsvpForm(GuestResponse response)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(response);
                return View("Thanks", response);
            }
            else
                return View();
        }

        public ViewResult ListResponses()
        {
            return View(Repository.getReponses().Where(r => r.WillAttend==true));
        }
    }
}