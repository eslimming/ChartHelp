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
        public ActionResult CharterHelp(int ancho=500, int alto=500, int v1=90, int v2=100, int v3=80, int v4=70)
        {
            string myTheme =
                   @"<Chart BackColor=""Transparent"" >
                                    <ChartAreas>
                                        <ChartArea Name=""Default"" BackColor=""Transparent""></ChartArea>
                                    </ChartAreas>
                                </Chart>";


            new Chart(width: ancho, height: alto, theme: ChartTheme.Green)
            //.AddTitle("Chart for languages")
                 .AddSeries(chartType: "radar",
                   xValue: new[] { "ASP.NET", "HTML5", "C Language", "C++" },
                     yValues: new[] { v1, v2, v3, v4 })
                   .Write("png");
            return null;
        }
    }
}