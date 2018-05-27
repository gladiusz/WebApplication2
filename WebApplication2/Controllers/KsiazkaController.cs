using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class KsiazkaController : Controller
    {
        public KsiazkaRepository ksiazki = new KsiazkaRepository();
        public AutorRepository autorzy = new AutorRepository();


        public ActionResult Index()
        {
            MainPageModel model = new MainPageModel(ksiazki.GetList(), autorzy);
            return View(model);
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

            EditPageModel model = new EditPageModel(ksiazka, autorzy.GetList());

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Guid? id, EditPageModel model)
        {
            model.AutorModelList = autorzy.GetList();
            if (!ModelState.IsValid)
                return View(model);

            if (id == null)
                ksiazki.Add(model.KsiazkaModel);
            else
            {
                EditPageModel lmodel = new EditPageModel(ksiazki.Get((Guid)id), autorzy.GetList());
                lmodel.KsiazkaModel.Tytul = model.KsiazkaModel.Tytul;
                lmodel.KsiazkaModel.AutorId = model.KsiazkaModel.AutorId;
                lmodel.KsiazkaModel.IloscStron = model.KsiazkaModel.IloscStron;
                lmodel.KsiazkaModel.Okladka = model.KsiazkaModel.Okladka;
            }
            return RedirectToAction("Index");
        }

    }
}