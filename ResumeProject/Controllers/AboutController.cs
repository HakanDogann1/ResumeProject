using ResumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAbout()
        {
           var result = db.TBLProfile.ToList();
            return PartialView(result);
        }

        public PartialViewResult PartialTechnology()
        {
            var result = db.TBLTechnology.ToList();
            return PartialView(result);
        }

        public PartialViewResult PartialBanner()
        {
            return PartialView();
        }

        public PartialViewResult PartialVideo()
        {
            return PartialView();
        }
        
        public PartialViewResult PartialTouch()
        {
            return PartialView();
        }
        public PartialViewResult PartialReviews()
        {
            var values = db.TBLReviews.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialScript() 
        {
        return PartialView();
        }
    }
}