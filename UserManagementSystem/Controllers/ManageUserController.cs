using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

/*
 * Name: MangeUserController.cs
 * Namespace: Controllers
 * Author: Namchok
 */

namespace UserManagementSystem.Controllers
{
    public class ManageUserController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
