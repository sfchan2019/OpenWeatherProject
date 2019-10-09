using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenWeatherAPI.Open_Weather_Service.Data_Handling
{
    class WeatherDTO
    {
        WeatherReportRoot WeatherReport { get; set; }
        public void DeserializeWeatherReport(string weatherReportResponse)
        {
            WeatherReport = JsonConvert.DeserializeObject<WeatherReportRoot>(weatherReportResponse);
        }
    }
}
