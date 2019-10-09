using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenWeatherAPI.Open_Weather_Service.Data_Handling;
using OpenWeatherAPI.Open_Weather_Service.HTTP_Manager;
using Newtonsoft.Json.Linq;


namespace OpenWeatherAPI.Open_Weather_Service
{
    class OpenWeatherService
    {
        //DTO
        public WeatherDTO weatherDTO = new WeatherDTO();
        //Call Manager
        OpenWeatherCallManager openWeatherCallManager = new OpenWeatherCallManager();
        //JObject
        public JObject weatherReportJson;
        public OpenWeatherService()
        {
            //weatherDTO.DeserializeWeatherReport(openWeatherCallManager.GetWeatherForecast());
            weatherReportJson = JObject.Parse(openWeatherCallManager.GetWeatherForecast());
        }
    }
}
