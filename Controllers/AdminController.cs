﻿using projectsem3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projectsem3.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private ManageStudentEntities ManageEntities = new ManageStudentEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Admission()
        {
            List<TABULAR> tabular = ManageEntities.TABULARs.Where(u => u.Status == false).ToList<TABULAR>();

            return View(tabular);
        }
        public ActionResult Update()
        {
            return View();
        }

    }
}