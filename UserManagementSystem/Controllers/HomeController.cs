using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
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
                FormattableString sqlString = @$"EXECUTE dbo.ums_getAll";
                ViewData["Account"] = context.Account.FromSqlInterpolated(sqlString).ToList();
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
