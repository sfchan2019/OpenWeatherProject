using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenWeatherAPI.Test.Open_Weather_Service.Data_Handling;
using OpenWeatherAPI.Test.Open_Weather_Service.HTTP_Manager;
using Newtonsoft.Json.Linq;


namespace OpenWeatherAPI.Test.Open_Weather_Service
{
    class OpenWeatherService
    {
        //DTO
        WeatherDTO weatherDTO = new WeatherDTO();
        //Call Manager
        OpenWeatherCallManager openWeatherCallManager = new OpenWeatherCallManager();
        //JObject
        JObject weatherResultJson;
        public OpenWeatherService()
        {
            weatherDTO.DeserializeWeatherReport(openWeatherCallManager.GetWeatherForecast());
        }


    }
}
