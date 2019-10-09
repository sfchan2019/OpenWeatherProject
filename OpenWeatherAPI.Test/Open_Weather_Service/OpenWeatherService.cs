using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenWeatherAPI.Open_Weather_Service.Data_Handling;
using OpenWeatherAPI.Open_Weather_Service.HTTP_Manager;
using RestSharp;
using System.Net;


namespace OpenWeatherAPI.Open_Weather_Service
{
    class OpenWeatherService
    {
        //DTO
        public WeatherDTO weatherDTO = new WeatherDTO();
        //Call Manager
        OpenWeatherCallManager openWeatherCallManager = new OpenWeatherCallManager();
        //Status
        public HttpStatusCode statusCode;
        

        public OpenWeatherService()
        {
            weatherDTO.DeserializeWeatherReport(openWeatherCallManager.GetWeatherForecast().Content);
            weatherDTO.ParseWeatherReportHeader(openWeatherCallManager.GetWeatherForecast().Headers);
            statusCode = openWeatherCallManager.GetWeatherForecast().StatusCode;
        }
    }
}
