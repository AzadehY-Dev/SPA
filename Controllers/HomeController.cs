using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPA.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return PartialView();
        }
        public ActionResult Add()
        {
            return PartialView();
        }
        public ActionResult Edit(int id)
        {
            return PartialView(id);
        }
    }
}