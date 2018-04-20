using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class BibliotekaController : Controller
    {
        static List<KsiazkaModel> data = new List<KsiazkaModel>();


        public ActionResult Index()
        {
            return View(data);
        }

        public ActionResult Delete(int id)
        {
            data.RemoveAt(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            return View(id != null
                ? data[(int)id]
                : new KsiazkaModel());
        }

        [HttpPost]
        public ActionResult Edit(int? id, KsiazkaModel ksiazka)
        {
            if (!ModelState.IsValid)
                return View(ksiazka);
            if (id == null)
                data.Add(ksiazka);
            else
                data[(int)id] = ksiazka;

            return RedirectToAction("Index");
        }

    }
}