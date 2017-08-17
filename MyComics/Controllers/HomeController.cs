using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyComics.ViewModels;
using MyComics.Services;
using Microsoft.Extensions.Configuration;

namespace MyComics.Controllers
{
    public class HomeController : Controller
    {
        private IMailService mailService;
        private IConfigurationRoot appSettings;

        public HomeController(IMailService mailService, IConfigurationRoot appSettings)
        {
            this.mailService = mailService;
            this.appSettings = appSettings;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Let us know what you think of the app!";
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if(ModelState.IsValid)
            {
                mailService.sendMail(appSettings["Email:ToAddress"], model.Email, model.Subject, model.Message);
                ModelState.Clear();
                ViewBag.Confirmation = "Message Sent";
            }
           
            return View();
        }

        public IActionResult Browse()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
