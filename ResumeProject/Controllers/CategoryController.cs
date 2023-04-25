using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            var result = db.TBLCategory.ToList();
            return View(result);
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var result = db.TBLCategory.Find(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult UpdateCategory(TBLCategory p) {
            var result = db.TBLCategory.Find(p.CategoryID);
            result.CategoryID = p.CategoryID;
            result.CategoryName = p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetMessageBySubject(int id)
        {
            var result = db.TBLContact.Where(x=>x.Subject == id).ToList();
            return View(result);
        }
    }
}