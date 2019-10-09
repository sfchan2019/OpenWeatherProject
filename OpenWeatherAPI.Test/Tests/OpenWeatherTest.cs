using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenWeatherAPI.Open_Weather_Service;
using System.Text.RegularExpressions;
using System.Net;

namespace OpenWeatherAPI.Tests
{
    [TestFixture]
    class OpenWeatherTest
    {
        public OpenWeatherService service = new OpenWeatherService();
        public OpenWeatherTest()
        {

        }

        [Test]
        public void Attribute_Coord_Lon_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.coord.lon);
        }

        [Test]
        public void Attribute_Coord_Lon_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.coord.lon);
        }

        [Test]
        public void Attribute_Coord_Lat_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.coord.lat);
        }

        [Test]
        public void Attribute_Coord_Lat_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.coord.lat);
        }


        [Test]
        public void Attribute_Weather_Id_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.weather[0].id);
        }

        [Test]
        public void Attribute_Weather_Id_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(double), service.weatherDTO.WeatherReport.weather[0].id);
        }

        [Test]
        public void Attribute_Weather_Id_Range_Test01()
        {
            Assert.GreaterOrEqual(service.weatherDTO.WeatherReport.weather[0].id, 0);
        }

        [Test]
        public void Attribute_Weather_Main_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.WeatherReport.weather[0].main);
        }

        [Test]
        public void Attribute_Weather_Main_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(char), service.weatherDTO.WeatherReport.weather[0].main);
        }

        [Test]
        public void Attribute_Weather_Main_Length_Test01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.weather[0].main.Length, 0);
        }

        [Test]
        public void Attribute_Weather_Description_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.WeatherReport.weather[0].description);
        }

        [Test]
        public void Attribute_Weather_Description_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(int), service.weatherDTO.WeatherReport.weather[0].description);
        }

        [Test]
        public void Attribute_Weather_Description_Length_Test01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.weather[0].description.Length, 0);
        }

        [Test]
        public void Attribute_Weather_Icon_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.WeatherReport.weather[0].icon);
        }

        [Test]
        public void Attribute_Weather_Icon_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(double), service.weatherDTO.WeatherReport.weather[0].icon);
        }

        [Test]
        public void Attribute_Weather_Icon_Length_Test01()
        {
            Assert.GreaterOrEqual(service.weatherDTO.WeatherReport.weather[0].icon.Length, 0);
        }

        [Test]
        public void Attribute_Base_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.WeatherReport.@base);
        }

        [Test]
        public void Attribute_Base_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(bool), service.weatherDTO.WeatherReport.@base);
        }

        [Test]
        public void Attribute_Base_Length_Test01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.@base.Length, 0);
        }

        [Test]
        public void Attribute_Main_Temp_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.main.temp);
        }

        [Test]
        public void Attribute_Main_Temp_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(char), service.weatherDTO.WeatherReport.main.temp);
        }

        [Test]
        public void Attribute_Main_Temp_Range_Test01()
        {
            Assert.GreaterOrEqual(service.weatherDTO.WeatherReport.main.temp, service.weatherDTO.WeatherReport.main.temp_min);
        }

        [Test]
        public void Attribute_Main_Temp_Range_Test02()
        {
            Assert.LessOrEqual(service.weatherDTO.WeatherReport.main.temp, service.weatherDTO.WeatherReport.main.temp_max);
        }

        [Test]
        public void Attribute_Main_Pressure_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.main.pressure);
        }

        [Test]
        public void Attribute_Main_Pressure_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(long), service.weatherDTO.WeatherReport.main.pressure);
        }

        [Test]
        public void Attribute_Main_Pressure_Range_Test01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.main.pressure, 0);
        }

        [Test]
        public void Attribute_Main_Humidity_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.main.humidity);
        }

        [Test]
        public void Attribute_Main_Humidity_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(double), service.weatherDTO.WeatherReport.main.humidity);
        }

        [Test]
        public void Attribute_Main_Humidity_Range_Test01()
        {
            Assert.GreaterOrEqual(service.weatherDTO.WeatherReport.main.humidity, 0);
        }

        [Test]
        public void Attribute_Main_Temp_Min_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.main.temp_min);
        }

        [Test]
        public void Attribute_Main_Temp_Min_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.main.temp_min);
        }

        [Test]
        public void Attribute_Main_Temp_Min_Range_Test01()
        {
            //temp_min should be less than or equal to temp_max
            Assert.LessOrEqual(service.weatherDTO.WeatherReport.main.temp_min, service.weatherDTO.WeatherReport.main.temp_max);
        }

        [Test]
        public void Attribute_Main_Temp_Max_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.main.temp_max);
        }

        [Test]
        public void Attribute_Main_Temp_Max_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(int), service.weatherDTO.WeatherReport.main.temp_max);
        }

        [Test]
        public void Attribute_Main_Sea_Level_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.main.sea_level);
        }

        [Test]
        public void Attribute_Main_Sea_Level_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(short), service.weatherDTO.WeatherReport.main.sea_level);
        }

        [Test]
        public void Attribute_Main_Grnd_Level_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.main.grnd_level);
        }

        [Test]
        public void Attribute_Main_Grnd_Level_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(char), service.weatherDTO.WeatherReport.main.grnd_level);
        }

        [Test]
        public void Attribute_Visibility_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.visibility);
        }

        [Test]
        public void Attribute_Visibility_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.visibility);
        }

        [Test]
        public void Attribute_Visibility_Range_Test01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.visibility, 0);
        }

        [Test]
        public void Attribute_Wind_Speed_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.wind.speed);
        }

        [Test]
        public void Attribute_Wind_Speed_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(bool), service.weatherDTO.WeatherReport.wind.speed);
        }

        [Test]
        public void Attribute_Wind_Speed_Range_Test()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.wind.speed, 0);
        }

        [Test]
        public void Attribute_Wind_Deg_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.wind.deg);
        }

        [Test]
        public void Attribute_Wind_Deg_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.wind.deg);
        }

        [Test]
        public void Attribute_Wind_Deg_Range_Test01()
        {
            Assert.GreaterOrEqual(service.weatherDTO.WeatherReport.wind.deg, 0);
        }

        [Test]
        public void Attribute_Wind_Deg_Range_Test02()
        {
            Assert.LessOrEqual(service.weatherDTO.WeatherReport.wind.deg, 360);
        }

        [Test]
        public void Attribute_Clouds_All_DataType_Test01()
        {

            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.clouds.all);
        }

        [Test]
        public void Attribute_Clouds_All_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(short), service.weatherDTO.WeatherReport.clouds.all);
        }

        [Test]
        public void Attribute_Dt_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.dt);
        }

        [Test]
        public void Attribute_Dt_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(double), service.weatherDTO.WeatherReport.dt);
        }

        [Test]
        public void Attribute_Sys_Type_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.sys.type);
        }

        [Test]
        public void Attribute_Sys_Type_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(bool), service.weatherDTO.WeatherReport.sys.type);
        }

        [Test]
        public void Attribute_Sys_Id_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.sys.id);
        }

        [Test]
        public void Attribute_Sys_Id_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(char), service.weatherDTO.WeatherReport.sys.id);
        }

        [Test]
        public void Attribute_Sys_Message_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.sys.message);
        }

        [Test]
        public void Attribute_Sys_Message_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.sys.message);
        }

        [Test]
        public void Attribute_Sys_Country_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.WeatherReport.sys.country);
        }

        [Test]
        public void Attribute_Sys_Country_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(double), service.weatherDTO.WeatherReport.sys.country);
        }

        [Test]
        public void Attribute_Sys_Country_Length_Test01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.sys.country.Length, 0);
        }

        [Test]
        public void Attribute_Sys_Sunrise_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.sys.sunrise);
        }

        [Test]
        public void Attribute_Sys_Sunrise_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(short), service.weatherDTO.WeatherReport.sys.sunrise);
        }

        [Test]
        public void Attribute_Sys_Sunrise_Range_Test01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.sys.sunrise, 0);
        }

        [Test]
        public void Attribute_Sys_Sunset_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.sys.sunset);
        }

        [Test]
        public void Attribute_Sys_Sunset_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(long), service.weatherDTO.WeatherReport.sys.sunset);
        }

        [Test]
        public void Attribute_Sys_Sunset_Range_Test01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.sys.sunset, 0);
        }

        [Test]
        public void Attribute_Rain_1h_DataType_Test01()
        {
            //Rain maybe null if weather is not rainning. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.rain != null)
            {
                Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.rain.oneHour);
            }
        }

        [Test]
        public void Attribute_Rain_1h_DataType_Test02()
        {
            //Rain maybe null if weather is not rainning. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.rain != null)
            {
                Assert.IsNotInstanceOf(typeof(char), service.weatherDTO.WeatherReport.rain.oneHour);
            }
        }

        [Test]
        public void Attribute_Rain_3h_DataType_Test01()
        {
            //Rain maybe null if weather is not rainning. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.rain != null)
            {
                Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.rain.threeHour);
            }
        }

        [Test]
        public void Attribute_Rain_3h_DataType_Test02()
        {
            //Rain maybe null if weather is not rainning. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.rain != null)
            {
                Assert.IsNotInstanceOf(typeof(int), service.weatherDTO.WeatherReport.rain.threeHour);
            }
        }

        [Test]
        public void Attribute_Snow_1h_DataType_Test01()
        {
            //Snow maybe null if weather is not snow. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.snow != null)
            {
                Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.snow.oneHour);
            }
        }

        [Test]
        public void Attribute_Snow_1h_DataType_Test02()
        {
            //Snow maybe null if weather is not snow. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.snow != null)
            {
                Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.snow.oneHour);
            }
        }

        [Test]
        public void Attribute_Snow_3h_DataType_Test01()
        {
            //Snow maybe null if weather is not snow. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.snow != null)
            {
                Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.snow.threeHour);
            }
        }

        [Test]
        public void Attribute_Snow_3h_DataType_Test02()
        {
            //Snow maybe null if weather is not snow. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.snow != null)
            {
                Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.snow.threeHour);
            }
        }

        [Test]
        public void Attribute_Timezone_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.timezone);
        }

        [Test]
        public void Attribute_Timezone_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.timezone);
        }

        [Test]
        public void Attribute_Id_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.id);
        }

        [Test]
        public void Attribute_Id_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(double), service.weatherDTO.WeatherReport.id);
        }

        [Test]
        public void Attribute_Id_Range_Test01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.id, 0);
        }

        [Test]
        public void Attribute_Name_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.WeatherReport.name);
        }

        [Test]
        public void Attribute_Name_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(int), service.weatherDTO.WeatherReport.name);
        }

        [Test]
        public void Attribute_Name_Length_Test01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.name.Length, 0);
        }

        [Test]
        public void Attribute_Cod_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.cod);
        }

        [Test]
        public void Attribute_Cod_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(bool), service.weatherDTO.WeatherReport.cod);
        }

        [Test]
        public void Header_Connection_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.ReportHeader.Connection);
        }

        [Test]
        public void Header_Connection_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(char), service.weatherDTO.ReportHeader.Connection);
        }

        [Test]
        public void Header_Connection_Value_Test01()
        {
            Assert.AreEqual("keep-alive", service.weatherDTO.ReportHeader.Connection);
        }

        [Test]
        public void Header_Connection_Value_Test02()
        {
            Assert.AreNotEqual("alive", service.weatherDTO.ReportHeader.Connection);
        }

        [Test]
        public void Header_Connection_Length_Test01()
        {
            Assert.Greater(service.weatherDTO.ReportHeader.Connection.Length, 0);
        }

        [Test]
        public void Header_Access_Control_Allow_Origin_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.ReportHeader.Access_Control_Allow_Origin);
        }

        [Test]
        public void Header_Access_Control_Allow_Origin_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(int), service.weatherDTO.ReportHeader.Access_Control_Allow_Origin);
        }

        [Test]
        public void Header_Access_Control_Allow_Origin_Value_Test01()
        {
            Assert.AreEqual("*", service.weatherDTO.ReportHeader.Access_Control_Allow_Origin);
        }

        [Test]
        public void Header_Access_Control_Allow_Origin_Value_Test02()
        {
            Assert.AreNotEqual("All", service.weatherDTO.ReportHeader.Access_Control_Allow_Origin);
        }

        [Test]
        public void Header_Access_Control_Allow_Origin_Length_Test01()
        {
            Assert.Greater(service.weatherDTO.ReportHeader.Access_Control_Allow_Origin.Length, 0);
        }

        [Test]
        public void Header_Access_Control_Allow_Credentials_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(bool), service.weatherDTO.ReportHeader.Access_Control_Allow_Credentials);
        }

        [Test]
        public void Header_Access_Control_Allow_Credentials_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.ReportHeader.Access_Control_Allow_Credentials);
        }

        [Test]
        public void Header_Access_Control_Allow_Credentials_Value_Test01()
        {
            Assert.AreEqual(true, service.weatherDTO.ReportHeader.Access_Control_Allow_Credentials);
        }

        [Test]
        public void Header_Access_Control_Allow_Credentials_Value_Test02()
        {
            Assert.AreNotEqual(false, service.weatherDTO.ReportHeader.Access_Control_Allow_Credentials);
        }

        [Test]
        public void Header_Access_Control_Allow_Methods_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.ReportHeader.Access_Control_Allow_Methods);
        }

        [Test]
        public void Header_Access_Control_Allow_Methods_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(bool), service.weatherDTO.ReportHeader.Access_Control_Allow_Methods);
        }

        [Test]
        public void Header_Access_Control_Allow_Methods_Value_Test01()
        {
            Assert.AreEqual("GET, POST", service.weatherDTO.ReportHeader.Access_Control_Allow_Methods);
        }

        [Test]
        public void Header_Access_Control_Allow_Methods_Value_Test02()
        {
            Assert.AreNotEqual("GET", service.weatherDTO.ReportHeader.Access_Control_Allow_Methods);
        }

        [Test]
        public void Header_Access_Control_Allow_Methods_Length_Test01()
        {
            Assert.Greater(service.weatherDTO.ReportHeader.Access_Control_Allow_Methods.Length, 0);
        }

        [Test]
        public void Header_X_Cache_Key_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.ReportHeader.X_Cache_Key);
        }

        [Test]
        public void Header_X_Cache_Key_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(int), service.weatherDTO.ReportHeader.X_Cache_Key);
        }

        [Test]
        public void Header_X_Cache_Key_Length_Test01()
        {
            Assert.Greater(service.weatherDTO.ReportHeader.X_Cache_Key.Length, 0);
        }

        [Test]
        public void Header_Content_Length_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.ReportHeader.Content_Length);
        }

        [Test]
        public void Header_Content_Length_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.ReportHeader.Content_Length);
        }

        [Test]
        public void Header_Content_Length_Range_Test01()
        {
            Assert.Greater(service.weatherDTO.ReportHeader.Content_Length, 0);
        }

        [Test]
        public void Header_Content_Type_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.ReportHeader.Content_Type);
        }

        [Test]
        public void Header_Content_Type_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(bool), service.weatherDTO.ReportHeader.Content_Type);
        }

        [Test]
        public void Header_Content_Type_Value_Test01()
        {
            Assert.AreEqual("application/json; charset=utf-8", service.weatherDTO.ReportHeader.Content_Type);
        }

        [Test]
        public void Header_Content_Type_Value_Test02()
        {
            Assert.AreNotEqual("application/xml;charset=utf-8", service.weatherDTO.ReportHeader.Content_Type);
        }

        [Test]
        public void Header_Content_Type_Length_Test01()
        {
            Assert.Greater(service.weatherDTO.ReportHeader.Content_Type.Length, 0);
        }

        [Test]
        public void Header_Server_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.ReportHeader.Server);
        }

        [Test]
        public void Header_Server_DataType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(int), service.weatherDTO.ReportHeader.Server);
        }

        [Test]
        public void Header_Server_Value_Test01()
        {
            Assert.AreEqual("openresty", service.weatherDTO.ReportHeader.Server);
        }

        [Test]
        public void Header_Server_Value_Test02()
        {
            Assert.AreNotEqual("Microsoft-IIS/8,5", service.weatherDTO.ReportHeader.Server);
        }

        [Test]
        public void Header_Server_Length_Test01()
        {
            Assert.Greater(service.weatherDTO.ReportHeader.Server.Length, 0);
        }

        [Test]
        public void Header_Date_DataType_Test01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.ReportHeader.Date);
        }

        [Test]
        public void Header_Date_DateType_Test02()
        {
            Assert.IsNotInstanceOf(typeof(DateTime), service.weatherDTO.ReportHeader.Date);
        }

        [Test]
        public void Header_Date_Format_Test01()
        {
            //format: Web dd OCT yyyy hh:mm:ss UDA
            string format = "([A-Z][a-z][a-z],) ([0-9][0-9])..([A-z])..[0-2][0-9][0-9][0-9] [0-2][0-9]:[0-6][0-9]:[0-6][0-9]..[A-Z][A-Z]";
            Assert.AreEqual(true, Regex.Match(service.weatherDTO.ReportHeader.Date, format).Success);
        }

        [Test]
        public void Header_Date_Length_Test01()
        {
            Assert.Greater(service.weatherDTO.ReportHeader.Date.Length, 0);
        }

        [Test]
        public void Response_Status_Test01()
        {
            Assert.AreEqual(HttpStatusCode.OK, service.statusCode);
        }

        [Test]
        public void Response_Status_Test02()
        {
            Assert.AreNotEqual(HttpStatusCode.NotFound, service.statusCode);
        }
    }
}
