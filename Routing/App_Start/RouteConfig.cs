using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing
{
    public class RouteConfig
    {
        //Linkte gönderilen parametreler RouteColection nesnesi ile alınıp RegisterRoute metoduna gönderilir.
        public static void RegisterRoutes(RouteCollection routes)
        {
            //kabul edilmeyen yönlendirmeler IgnoreRoute ile tanımlanır. I
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //kabul edilen yönlendirmeler de MapRoute ile tanımlanır.
            routes.MapRoute(
                name: "Anasayfa",
                url: "anasayfa",
                defaults: new { controller = "Site", action = "Anasayfa", id = UrlParameter.Optional }
                //kullanıcı siteyi sadece site adıyla açmak isterse SiteController'ın Anasayfa metoduna otomatik olarak yönlendirme yapılır.
            );

            int kategori_kırılım_sayisi = 3;
            string kategori_url = "kategori";

            //for (int i = 0; i < kategori_kırılım_sayisi; i++)
            //{
            //    kategori_url += "/{kategori" + i + "}";

            //    routes.MapRoute(
            //        name: "kategori" + i,
            //        url: kategori_url,
            //        defaults: new { controller = "HaberKategori", action = "Anasayfa" }

            //    );
            //}

                string haberUrl = "haber";

                for (int a = 0; a < kategori_kırılım_sayisi; a++)
                {
                    kategori_url += "/{kategori" + a + "}";

                    routes.MapRoute(
                        name: "kategori" + a,
                        url: kategori_url,
                        defaults: new { controller="HaberKategori", action="Anasayfa" }
                      
                        );

                    haberUrl += "/{kategori" + a + "}";
                    routes.MapRoute(
                        name: "haber" + a,
                        url: haberUrl + "/{haber}",
                        defaults: new { controller = "Haber", action = "Detay" }
  
                        );

                }
            }
        }
    }
