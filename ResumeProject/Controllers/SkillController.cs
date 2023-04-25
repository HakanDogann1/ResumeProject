using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class SkillController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            var values = db.TBLSkill.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(TBLSkill p)
        {
            db.TBLSkill.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSkill(int id)
        {
            var value = db.TBLSkill.Find(id);
            db.TBLSkill.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = db.TBLSkill.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSkill(TBLSkill tbl)
        {
            TBLSkill result = db.TBLSkill.SingleOrDefault(x => x.SkillId == tbl.SkillId);
            result.SkillId = tbl.SkillId;
            result.SkillIcon = tbl.SkillIcon;
            result.SkillTitle = tbl.SkillTitle;
            result.SkillDescription = tbl.SkillDescription;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}