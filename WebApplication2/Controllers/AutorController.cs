using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AutorController : Controller
    {
        protected Guid? userId = null;
        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            var Session = System.Web.HttpContext.Current.Session;
            if (Session != null)
            {
                userId = (Guid?)Session["UserId"];
            }
            return base.BeginExecute(requestContext, callback, state);
        }

        public AutorRepository autorzy = new AutorRepository();

        [HttpGet]
        public ActionResult Edit()
        {
            if (userId == null)
                throw new HttpException(403, "Brak dostepu");
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