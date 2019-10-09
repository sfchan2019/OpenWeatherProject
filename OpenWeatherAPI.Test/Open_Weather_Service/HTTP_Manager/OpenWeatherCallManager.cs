using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RestSharp;

namespace OpenWeatherAPI.Open_Weather_Service.HTTP_Manager
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
            string param = String.Format("/weather?q={0},{1}&", "London", "uk");
            RestRequest request = new RestRequest(param + OpenWeatherConfig.ApiUrlMod + OpenWeatherConfig.ApiKey);
            IRestResponse response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
