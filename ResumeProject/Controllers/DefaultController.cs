using ResumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            return View();
        }

       public PartialViewResult partial1()
        {
            return PartialView();
        }

        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.TBLProfile.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialServices()
        {
            var values = db.TBLServices.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTechnology()
        {
            var values = db.TBLTechnology.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialCounter()
        {
            ViewBag.skillCount = db.TBLSkill.Count();
            ViewBag.serviceCount = db.TBLServices.Count();
            ViewBag.avgTechnologyValue = db.TBLTechnology.Average(x => x.TechnologyCalue);
            ViewBag.happyCustomer = 38;
            return PartialView();
        }

        public PartialViewResult PartialProjects()
        {
            return PartialView();
        }

        public PartialViewResult PartialBrands()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}