﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost] 
        public ActionResult LoginAction(Account acc)
        {
                ViewBag.Title = acc.password + "!!" ;
                return View("Login");
        }
    }
}