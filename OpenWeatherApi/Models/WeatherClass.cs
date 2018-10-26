using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace OpenWeatherApi.Models
{
    public class WeatherClass
    {

        public   object GetWeatherNow(string location)
        {
            //string endpoint = "e2404cfaf18671eab5bd822f5501f69a";
             const string apicode = "e2404cfaf18671eab5bd822f5501f69a";
            string url = "http://api.openweathermap.org/data/2.5/weather?q="+location+"&appid=" + apicode;
            var clinet = new WebClient();
            var content = clinet.DownloadString(url);

            var serliztaion = new JavaScriptSerializer();
            var jsonContent = serliztaion.Deserialize<item>(content);
            return (jsonContent.temp+jsonContent.humidity);
             
        }

    }
}