using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

/*
 * Name: LoginController.cs
 * Namespace: Controllers
 * Author: Namchok
 */

namespace UserManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        /*
         * Name: Index
         * Author: System created
         * Description: page for 
         */
        public IActionResult Index()
        {
            /*
             * statement for get data from database
             */
            return View();
        }
    }
}
