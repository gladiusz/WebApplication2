using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AutorController : Controller
    {
        public AutorRepository autorzy = new AutorRepository();

        [HttpGet]
        public ActionResult Edit()
        {
            AutorModel autor = new AutorModel();
            return View(autor);
        }

        [HttpPost]
        public ActionResult Edit(AutorModel autor)
        {
            autorzy.Add(autor);
            return RedirectToAction("Index", "Ksiazka");
        }
    }
}