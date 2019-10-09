using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace OpenWeatherAPI.Open_Weather_Service.Data_Handling
{
    class WeatherDTO
    {
        public WeatherReportRoot WeatherReport { get; set; }
        public WeatherReportHeader ReportHeader { get; set; }
        public void DeserializeWeatherReport(string weatherReportResponse)
        {
            WeatherReport = JsonConvert.DeserializeObject<WeatherReportRoot>(weatherReportResponse);
        }

        public void ParseWeatherReportHeader(IList<Parameter> headerRest)
        {
            ReportHeader = new WeatherReportHeader();
            ReportHeader.Connection = headerRest[0].Value as string;
            ReportHeader.X_Cache_Key = headerRest[1].Value as string;
            ReportHeader.Access_Control_Allow_Origin = headerRest[2].Value as string;
            //May cause problem? say header[3] is null will return false
            ReportHeader.Access_Control_Allow_Credentials = (headerRest[3].Value.ToString() == "true");
            ReportHeader.Access_Control_Allow_Methods = headerRest[4].Value as string;
            ReportHeader.Content_Length = headerRest[5].Value as int?;
            ReportHeader.Content_Type = headerRest[6].Value as string;
            ReportHeader.Date = headerRest[7].Value as string;
            ReportHeader.Server = headerRest[8].Value as string;
        }
    }
}
