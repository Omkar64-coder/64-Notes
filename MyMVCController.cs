using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApplication.Models;
using System.Data.Entity;

namespace MVCApplication.Controllers
{
    public class MyMVCController : Controller
    {
        Database1Entities db = new Database1Entities();
        // GET: MyMVC
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Table t1)
        {
            db.Tables.Add(t1);
            db.SaveChanges();
            return RedirectToAction("Display");
        }

        [HttpGet]
        public ActionResult Display()
        {
            var obj = db.Tables.ToList();
            return View(obj);
        }

        [HttpPost]
        public ActionResult Edit(Table t1)
        {
            db.Entry(t1).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Display");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var obj = db.Tables.Find(id);
            return View(obj);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var obj = db.Tables.Find(id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Delete(Table t1)
        {
            db.Entry(t1).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Display");
        }
    }
}