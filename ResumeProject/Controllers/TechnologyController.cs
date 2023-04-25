using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class TechnologyController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            var values = db.TBLTechnology.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddTechnology()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTechnology(TBLTechnology p)
        {
            db.TBLTechnology.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTechnology(int id)
        {
            var result = db.TBLTechnology.Find(id);
            db.TBLTechnology.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTechnology(int id)
        {
            var values = db.TBLTechnology.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateTechnology(TBLTechnology p)
        {
            var result = db.TBLTechnology.Find(p.TechnologyId);
            result.TechnologyId = p.TechnologyId;
            result.TechnologyTitle  = p.TechnologyTitle;
            result.TechnologyCalue= p.TechnologyCalue;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}