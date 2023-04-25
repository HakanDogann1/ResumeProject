using ResumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            var result = db.TBLProject.ToList();
            return View(result);
        }

        [HttpGet]
        public ActionResult ProjectAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProjectAdd(TBLProject p)
        {
            var result = db.TBLProject.Find(p.ProjectId);
            db.TBLProject.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ProjectUpdate(int id)
        {
            var result = db.TBLProject.Find(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult ProjectUpdate(TBLProject p)
        {
            var result = db.TBLProject.Find(p.ProjectId);
            result.ProjectImageUrl = p.ProjectImageUrl;
            result.ProjectId = p.ProjectId;
            result.ProjectTitle = p.ProjectTitle;
            result.ProjectDescription = p.ProjectDescription;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult ProjectDelete(int id)
        {
            var result = db.TBLProject.Find(id);
            db.TBLProject.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}