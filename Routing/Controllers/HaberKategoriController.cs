using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{
    public class HaberKategoriController : Controller
    {
        //
        // GET: /HaberKategori/
        public ActionResult Anasayfa()
        {
            //ViewBag.KategoriAdi = kategori;
            int route_sirasi = this.RouteData.Values.Values.Count - 3;
            string kategori = this.RouteData.Values["kategori" + route_sirasi].ToString();

            ViewBag.Kategoriadi = kategori;
            return View();
        }
	}
}