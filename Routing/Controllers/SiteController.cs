using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{
    public class SiteController : Controller
    {
        //
        // GET: /Site/
        public ActionResult Anasayfa()
        {
            return View();
        }
	}
}