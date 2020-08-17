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
         * Description: first page
         */
        public IActionResult Index()
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

        /*
         * Name: ResetPassword
         * Author: Wannapa Srijermtong
         * Description: Reset password page
        */
        public IActionResult ResetPassword()
        {
            return View();
        }
    }
}
