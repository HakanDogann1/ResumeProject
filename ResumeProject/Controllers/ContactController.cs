using ResumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class ContactController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            var values = db.TBLContact.ToList();
            return View(values);
        }

        public ActionResult DeleteContact(int id)
        {
            var result = db.TBLContact.Find(id);
            db.TBLContact.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult SendMessage()
        {
            List<SelectListItem> values = (from x in db.TBLCategory.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();

            ViewBag.v=values;
            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(TBLContact p)
        {
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TBLContact.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index","Default");
        }

        public PartialViewResult PartialMap()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
    }
}