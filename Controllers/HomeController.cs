using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet("")]
        public IActionResult Forms()
        {
            return View();
        }
        //---------------------------------------------------------
        // [HttpGet("result")]
        // public IActionResult Result()
        // {
        //     return View();
        // }
        //---------------------------------------------------------
        [HttpPost("result")]
        public IActionResult Result(Submission newForm)
        {
            Console.WriteLine(newForm.LastName);

            if(ModelState.IsValid)
            {
                //validations are met
                Console.WriteLine(newForm.Email);
                return View(newForm);
            }
            else
            {
                return View("Forms");
            }
            // return View(newForm);
            // return RedirectToAction("Forms");
        }

        //---------------------------------------------------------
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
        //---------------------------------------------------------------


    }
}
