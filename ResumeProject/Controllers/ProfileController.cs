using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            var result = db.TBLProfile.ToList();
            return View(result);
        }
        [HttpGet]
        public ActionResult ProfileAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProfileAdd(TBLProfile p)
        {
            db.TBLProfile.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ProfileUpdate(int id)
        {
            var result = db.TBLProfile.Find(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult ProfileUpdate(TBLProfile p)
        {
            var result = db.TBLProfile.Find(p.ProfileId);
            result.ProfileDescription = p.ProfileDescription;
            result.SocialMedia1 = p.SocialMedia1;
            result.Address=p.Address;
            result.SocialMedia2 = p.SocialMedia2;
            result.SocialMedia3 = p.SocialMedia3;
            result.SocialMedia4 = p.SocialMedia4;
            result.Name=p.Name;
            result.ProfileTitle=p.ProfileTitle;
            result.Address = p.Address;
            result.Mail = p.Mail;
            result.Phone = p.Phone;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ProfileDelete(int id)
        {
            var result = db.TBLProfile.Find(id);
            db.TBLProfile.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}