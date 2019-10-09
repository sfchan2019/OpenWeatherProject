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

        public string GetWeatherForecast(string op, string z, string x, string y, string date)
        {
            string param = String.Format("/weather/{{0}}/{{1}}/{{2}}/{{3}}/{{4}}", op, z, x, y, date);
            RestRequest request = new RestRequest(param + OpenWeatherConfig.ApiUrlMod + OpenWeatherConfig.ApiKey);
            IRestResponse response = client.Execute(request, Method.GET);
            return response.Content;
        }

        public string GetWeatherForecast(string z, string x, string y, string date)
        {
            string param = String.Format("/weather/TA2/{{0}}/{{1}}/{{2}}/{{3}}", z, x, y, date);
            RestRequest request = new RestRequest(param + OpenWeatherConfig.ApiUrlMod + OpenWeatherConfig.ApiKey);
            IRestResponse response = client.Execute(request, Method.GET);
            return response.Content;
        }

        public string GetCurrentWeatherForecast(string op, string z, string x, string y)
        {
            string param = String.Format("/weather/{{0}}/{{1}}/{{2}}/{{3}}/{{4}}", op, z, x, y);
            RestRequest request = new RestRequest(param + OpenWeatherConfig.ApiUrlMod + OpenWeatherConfig.ApiKey);
            IRestResponse response = client.Execute(request, Method.GET);
            return response.Content;
        }

        public string GetCurrentWeatherForecast(string z, string x, string y)
        {
            string param = String.Format("/weather/TA2/{{0}}/{{1}}/{{2}}/{{3}}", z, x, y);
            RestRequest request = new RestRequest(param + OpenWeatherConfig.ApiUrlMod + OpenWeatherConfig.ApiKey);
            IRestResponse response = client.Execute(request, Method.GET);
            return response.Content;
        }

        public string GetWeatherForecast()
        {
            string param = String.Format("/weather/TA2/{{0}}/{{1}}/{{2}}/{{3}}");
            RestRequest request = new RestRequest(param + OpenWeatherConfig.ApiUrlMod + OpenWeatherConfig.ApiKey);
            IRestResponse response = client.Execute(request, Method.GET);
            return response.Content;
        }

    }
}
