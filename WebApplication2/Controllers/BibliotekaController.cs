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
        public KsiazkaRepository ksiazki = new KsiazkaRepository();


        public ActionResult Index()
        {
            return View(ksiazki.GetList());
        }

        public ActionResult Delete(Guid id)
        {
            ksiazki.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(Guid? id)
        {
            KsiazkaModel ksiazka;
            if (id != null)
                ksiazka = ksiazki.Get((Guid)id);
            else
                ksiazka = new KsiazkaModel();

            return View(ksiazka);
        }

        [HttpPost]
        public ActionResult Edit(Guid? id, KsiazkaModel ksiazka)
        {
            if (!ModelState.IsValid)
                return View(ksiazka);

            if (id == null)
                ksiazki.Add(ksiazka);
            else
            {
                KsiazkaModel lksiazka = ksiazki.Get((Guid)id);
                lksiazka.Tytul = ksiazka.Tytul;
                lksiazka.Autor = ksiazka.Autor;
                lksiazka.IloscStron = ksiazka.IloscStron;
                lksiazka.Okladka = ksiazka.Okladka;
            }
            return RedirectToAction("Index");
        }

    }
}