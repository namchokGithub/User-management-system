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
         * Name: index
         * Author: System created
         * Description: first page
         */
        public IActionResult index()
        {
            /*
             * statement for get data from database
             */
            Console.WriteLine("index");
            return View();
        }

        /*
         * Name: ForgotPassword
         * Author: Wannapa Srijermtong
         * Description: Forgot password page
        */
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
