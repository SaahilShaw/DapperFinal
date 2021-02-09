﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DapperFinal.Controllers
{
    public class RouteController : Controller
    {
        // GET: Route
        public ActionResult BackButton()
        {
            return RedirectToAction("Search","Menu");
        }
        public ActionResult BackButtonForMenu()
        {
            return RedirectToAction("MenuView", "Menu");
        }
    }
}