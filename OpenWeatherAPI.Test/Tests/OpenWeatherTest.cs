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
            Assert.AreEqual(typeof(double), service.weatherDTO.WeatherReport.coord.lon.GetType());
        }

        [Test]
        public void Attribute_Coord_Lat_DataType_Test()
        {
            Assert.AreEqual(typeof(double), service.weatherDTO.WeatherReport.coord.lat.GetType());
        }

        [Test]
        public void Attribute_Weather_Id_DataType_Test()
        {
            Assert.AreEqual(typeof(int), service.weatherDTO.WeatherReport.weather[0].id.GetType());
        }

        [Test]
        public void Attribute_Weather_Main_DataType_Test()
        {
            Assert.AreEqual(typeof(string), service.weatherDTO.WeatherReport.weather[0].main.GetType());
        }

        [Test]
        public void Attribute_Weather_Description_DataType_Test()
        {
            Assert.AreEqual(typeof(string), service.weatherDTO.WeatherReport.weather[0].description.GetType());
        }

        [Test]
        public void Attribute_Weather_Icon_DataType_Test()
        {
            Assert.AreEqual(typeof(string), service.weatherDTO.WeatherReport.weather[0].icon.GetType());
        }

        [Test]
        public void Attribute_Base_DataType_Test()
        {
            Assert.AreEqual(typeof(string), service.weatherDTO.WeatherReport.@base.GetType());
        }

        [Test]
        public void Attribute_Main_Temp_DataType_Test()
        {
            Assert.AreEqual(typeof(double), service.weatherDTO.WeatherReport.main.temp.GetType());
        }

        [Test]
        public void Attribute_Main_Pressure_DataType_Test()
        {
            Assert.AreEqual(typeof(int), service.weatherDTO.WeatherReport.main.pressure.GetType());
        }

        [Test]
        public void Attribute_Main_Humidity_DataType_Test()
        {
            Assert.AreEqual(typeof(int), service.weatherDTO.WeatherReport.main.humidity.GetType());
        }

        [Test]
        public void Attribute_Main_Temp_Min_DataType_Test()
        {
            Assert.AreEqual(typeof(double), service.weatherDTO.WeatherReport.main.temp_min.GetType());
        }

        [Test]
        public void Attribute_Main_Temp_Max_DataType_Test()
        {
            Assert.AreEqual(typeof(double), service.weatherDTO.WeatherReport.main.temp_max.GetType());
        }

        [Test]
        public void Attribute_Main_Sea_Level_DataType_Test()
        {
            Assert.AreEqual(typeof(double), service.weatherDTO.WeatherReport.main.sea_level.GetType());
        }

        [Test]
        public void Attribute_Main_Grnd_Level_DataType_Test()
        {
            Assert.AreEqual(typeof(double), service.weatherDTO.WeatherReport.main.grnd_level.GetType());
        }

        [Test]
        public void Attribute_Visibility_Test()
        {
            Assert.AreEqual(typeof(int), service.weatherDTO.WeatherReport.visibility.GetType());
        }

        [Test]
        public void Attribute_Wind_Speed_Test()
        {
            Assert.AreEqual(typeof(double), service.weatherDTO.WeatherReport.wind.speed.GetType());
        }

        [Test]
        public void Attribute_Wind_Deg_Test()
        {
            Assert.AreEqual(typeof(int), service.weatherDTO.WeatherReport.wind.deg.GetType());
        }

        [Test]
        public void Attribute_Clouds_All_Test()
        {
            Assert.AreEqual(typeof(int), service.weatherDTO.WeatherReport.clouds.all.GetType());
        }

        [Test]
        public void Attribute_Dt_Test()
        {
            Assert.AreEqual(typeof(int), service.weatherDTO.WeatherReport.dt.GetType());
        }

        [Test]
        public void Attribute_Sys_Test()
        {
        }

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
