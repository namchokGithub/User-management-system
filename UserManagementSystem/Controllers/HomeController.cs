using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UserManagementSystem.Models;

/*
 * Name: HomeController.cs
 * Namespace: Controllers
 * Author: Namchok
 */

namespace UserManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseContext context;

        public HomeController(ILogger<HomeController> logger, DatabaseContext cc)
        {
            this.context = cc;
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }

        /*
         * test connect database
         */
        public IActionResult Connect()
        {
            try
            {
                ViewData["Account"] = context.Account.FromSqlInterpolated($"EXECUTE dbo.getAll").ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
