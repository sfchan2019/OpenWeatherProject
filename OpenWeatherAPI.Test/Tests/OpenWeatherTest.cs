using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenWeatherAPI.Open_Weather_Service;

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
        public void Attribute_Coord_Lon_DataType_Test()
        {
            //Becaue the return values change everyday, the test with hardcoded value may not pass on the next day, Therefore
            //Test the return values are the same data type
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.coord.lon);
        }

        [Test]
        public void Attribute_Coord_Lat_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.coord.lat);
        }

        [Test]
        public void Attribute_Weather_Id_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.weather[0].id);
        }

        [Test]
        public void Attribute_Weather_Main_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.WeatherReport.weather[0].main);
        }

        [Test]
        public void Attribute_Weather_Description_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.WeatherReport.weather[0].description);
        }

        [Test]
        public void Attribute_Weather_Icon_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.WeatherReport.weather[0].icon);
        }

        [Test]
        public void Attribute_Base_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.WeatherReport.@base);
        }

        [Test]
        public void Attribute_Main_Temp_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.main.temp);
        }

        [Test]
        public void Attribute_Main_Pressure_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.main.pressure);
        }

        [Test]
        public void Attribute_Main_Humidity_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.main.humidity);
        }

        [Test]
        public void Attribute_Main_Temp_Min_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.main.temp_min);
        }

        [Test]
        public void Attribute_Main_Temp_Max_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.main.temp_max);
        }

        [Test]
        public void Attribute_Main_Sea_Level_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.main.sea_level);
        }

        [Test]
        public void Attribute_Main_Grnd_Level_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.main.grnd_level);
        }

        [Test]
        public void Attribute_Visibility_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.visibility);
        }

        [Test]
        public void Attribute_Wind_Speed_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.wind.speed);
        }

        [Test]
        public void Attribute_Wind_Deg_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.wind.deg);
        }

        [Test]
        public void Attribute_Clouds_All_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.clouds.all);
        }

        [Test]
        public void Attribute_Dt_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.dt);
        }

        [Test]
        public void Attribute_Sys_Type_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.sys.type);
        }

        [Test]
        public void Attribute_Sys_Id_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.sys.id);
        }

        [Test]
        public void Attribute_Sys_Message_DataType_Test()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.sys.message);
        }

        [Test]
        public void Attribute_Sys_Test()
        {
        }

        //[Test]
        //public void Attribute_Sys_Test()
        //{
        //}

        //[Test]
        //public void Attribute_Sys_Test()
        //{
        //}

        [Test]
        public void Attribute_Timezone_Test()
        {

        }

        [Test]
        public void Attribute_Id_Test()
        {

        }

        [Test]
        public void Attribute_Name_Test()
        {

        }

        [Test]
        public void Attribute_Cod_Test()
        {

        }
    }
}
