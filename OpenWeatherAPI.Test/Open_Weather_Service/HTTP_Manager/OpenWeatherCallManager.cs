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
        IRestResponse response;
        public OpenWeatherCallManager()
        {
            client = new RestClient(OpenWeatherConfig.BaseUrl);
        }
        public IRestResponse GetWeatherForecast()
        {
            string param = String.Format("/weather?q={0},{1}&", "London", "uk");
            RestRequest request = new RestRequest(param + OpenWeatherConfig.ApiUrlMod + OpenWeatherConfig.ApiKey);
            response = client.Execute(request, Method.GET);
            
            //response.StatusCode;  //status:200

            return response;
        }
    }
}
