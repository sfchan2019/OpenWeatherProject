using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace OpenWeatherAPI
{
    public static class OpenWeatherConfig
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings.Get("base_url");
        public static readonly string ApiKey = ConfigurationManager.AppSettings.Get("api_key");
        public static readonly string ApiUrlMod = ConfigurationManager.AppSettings.Get("access_key_url_mod");
    }
}
