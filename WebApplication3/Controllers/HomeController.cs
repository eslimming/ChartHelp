using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
namespace Web_APIcharter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CharterHelp(int ancho=500, int alto=500)
        {
            new Chart(width: ancho, height: alto)
            //.AddTitle("Chart for languages")
                 .AddSeries(chartType: "radar",
                   xValue: new[] { "ASP.NET", "HTML5", "C Language", "C++" },
                     yValues: new[] { "90", "100", "80", "70" })
                   .Write("bmp");
            return null;
        }
    }
}