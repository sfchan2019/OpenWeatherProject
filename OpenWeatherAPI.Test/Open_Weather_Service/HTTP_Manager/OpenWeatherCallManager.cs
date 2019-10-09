using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RestSharp;

namespace OpenWeatherAPI.Test.Open_Weather_Service.HTTP_Manager
{
    class OpenWeatherCallManager
    {
        readonly IRestClient client;
        public OpenWeatherCallManager()
        {
            client = new RestClient(OpenWeatherConfig.BaseUrl);
        }

        public string GetWeatherForecast()
        {
            RestRequest request = new RestRequest("/something" + OpenWeatherConfig.ApiUrlMod + OpenWeatherConfig.ApiKey);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

    }
}
