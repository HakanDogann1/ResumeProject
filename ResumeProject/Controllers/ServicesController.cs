using ResumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialBanner()
        {
            return PartialView();
        }

        public PartialViewResult PartialServices()
        {
            var values = db.TBLServices.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialProjectExecution()
        {
            return PartialView();
        }
    }
}