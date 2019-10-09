using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace OpenWeatherAPI.Open_Weather_Service.Data_Handling
{
    class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    class Main
    {
        public double temp { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public double sea_level { get; set; }
        public double grnd_level { get; set; }
    }

    class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
    }

    [DataContract]
    class Rain
    {
        //issues
        [DataMember(Name = "1h")]
        public double oneHour { get; set; }
        [DataMember(Name = "3h")]
        public double threeHour { get; set; }
    }

    [DataContract]
    class Snow
    {
        [DataMember(Name = "1h")]
        public double oneHour { get; set; }

        [DataMember(Name = "3h")]
        public double threeHour { get; set; }
    }

    class Clouds
    {
        public int all { get; set; }
    }

    class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public double message { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    class WeatherReportRoot
    {
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Rain rain { get; set; }
        public Snow snow { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }

    //class WeatherReportHeader
    //{
    //    public string Connection { get; set; }
    //    public string X_Cache_Key { get; set; }
    //    public string Access_Control_Allow_Origin { get; set; }
    //    public string Access_Control_Allow_Credentials { get; set; }
    //    public string Access_Control_Allow_Methods { get; set; }
    //    public int? Content_Length { get; set; }
    //    public string Content_Type { get; set; }
    //    public string Date { get; set; }
    //    public string Server { get; set; }

    //}
}
