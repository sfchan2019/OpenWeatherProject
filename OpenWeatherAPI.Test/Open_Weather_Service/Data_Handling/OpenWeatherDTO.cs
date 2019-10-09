using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenWeatherAPI.Test.Open_Weather_Service.Data_Handling
{
    class OpenWeatherDTO
    {
        WeatherReportRoot weatherReport { get; set; }
        public void DeserializeWeatherForecast(string forecastWeatherResponse)
        {
            weatherReport = JsonConvert.DeserializeObject<WeatherReportRoot>(forecastWeatherResponse);
        }
    }
}
