using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;
namespace ResumeProject.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            //ViewBag.SkillCount = db.TBLSkill.Count();
            ViewBag.CountProjeTalebi = db.CountProjeTalebi().FirstOrDefault();
            ViewBag.TechnologyCount = db.TBLTechnology.Count();
            ViewBag.csharpValue = db.TBLTechnology.Where(x => x.TechnologyTitle == "C# Programlama").Select(y => y.TechnologyCalue).FirstOrDefault();
            ViewBag.ContactCount = db.TBLContact.Count();
            ViewBag.SubjectTesekkur = db.TBLContact.Where(x=>x.Subject==1).Count();
            ViewBag.SumTechnologyValue = db.TBLTechnology.Sum(x => x.TechnologyCalue);
            ViewBag.AvarageTechnologyValue=db.TBLTechnology.Average(x => x.TechnologyCalue);
            ViewBag.GetBy3Id=db.TBLSkill.Where(x=>x.SkillId==3).Select(y=>y.SkillTitle).FirstOrDefault();
            ViewBag.MaxTechnologyValue = db.TBLTechnology.Max(x=>x.TechnologyCalue);
            return View();
        }
    }
}