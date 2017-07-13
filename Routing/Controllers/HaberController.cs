using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{
    public class HaberController : Controller
    {
        //
        // GET: /Haber/
        public ActionResult Detay(string haber)
        {
            ViewBag.HaberAdi = haber;
            return View();
        }
	}
}