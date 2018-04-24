﻿using CyberAcademy.Web.Logics;
using CyberAcademy.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace CyberAcademy.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ContactManager _contactMgr;

        public HomeController()
        {
            _contactMgr = new ContactManager();
        }

        public string GetDate()
        {
            return DateTime.Now.ToLongDateString();
        }
        // GET: Home
        public ActionResult Index()
        {
            //var claimsPrincipal = this.User.Identity as ClaimsIdentity;

          // var claim = claimsPrincipal.FindFirst("PassportUrl");

           // ViewBag.ProfileUrl = claim.Value;
            ViewData["SalesAnalyticsCaptions"] = "Sales Analytics";
            ViewBag.Contacts = _contactMgr.GetContacts();
            return View();
        }
    }
}