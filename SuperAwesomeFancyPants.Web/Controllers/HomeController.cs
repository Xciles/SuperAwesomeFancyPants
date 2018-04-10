using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperAwesomeFancyPants.Web.Models;

namespace SuperAwesomeFancyPants.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            Console.WriteLine("Constructor!");
            Test();
            Console.WriteLine("Constructor! End");
        }

        private async Task Test()
        {
            Console.WriteLine("Hi!");
            await Task.Delay(10000);
            Console.WriteLine("Hi! End");
        }

        public async Task<IActionResult> Index()
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
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
