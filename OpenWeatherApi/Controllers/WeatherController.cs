using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OpenWeatherApi.Models;
using System.Web.Script.Serialization;
using System.Net;

namespace OpenWeatherApi.Controllers
{
    public class WeatherController : Controller
    {
       

        public ActionResult GetWeather()
        {

            return View();
        }

        // GET: Weather
        public JsonResult GetWeatherData()
        {
            WeatherClass s = new WeatherClass();
            var dd = s.GetWeatherNow("egypt");
            //WeatherClass.GetWeatherNow("egypt");

            return Json(dd,JsonRequestBehavior.AllowGet);

        }
    }
}