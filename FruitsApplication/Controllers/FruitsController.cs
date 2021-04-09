using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FruitsApplication.Controllers
{
    public class FruitsController : Controller
    {
        // GET: Fruits

        public ActionResult index()
        {
            return View();
        }
        public ActionResult SideManu()
        {
            return PartialView("_Commonfolder");
        }
        public ActionResult Amrud()
        {
            return View();
        }
        public ActionResult Mango()
        {
            return View();
        }
        public ActionResult Apple()
        {
            return View();
        }
        public ActionResult Banana()
        {
            return View();
        }
        public ActionResult Pineapple()
        {
            return View();
        }
        public ActionResult Grapes()
        {
            return View();
        }
       
    }
} 