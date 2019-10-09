﻿using System;
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
        public void Attribute_Coord_Lon_Value_Test()
        {
            Assert.AreEqual(-0.13, service.weatherDTO.WeatherReport.coord.lon);
        }

        [Test]
        public void Attribute_Coord_Lat_Value_Test()
        {
            Assert.AreEqual(51.51, service.weatherDTO.WeatherReport.coord.lat);
        }

        [Test]
        public void Attribute_Coord_Lon_DataType_Test()
        {
            //Becaue the return values change everyday, the test with hardcoded value may not pass on the next day, Therefore
            //Test the return values are the same data type
            Assert.AreEqual((-0.13).GetType(), service.weatherDTO.WeatherReport.coord.lon.GetType());
        }

        [Test]
        public void Attribute_Coord_Lat_DataType_Test()
        {
            Assert.AreEqual((51.51).GetType(), service.weatherDTO.WeatherReport.coord.lat.GetType());
        }

        [Test]
        public void Attribute_Weather_Id_Value_Test()
        {
            Assert.AreEqual(803, service.weatherDTO.WeatherReport.weather[0].id);
        }

        [Test]
        public void Attribute_Weather_Main_Value_Test()
        {
            Assert.AreEqual("Clouds", service.weatherDTO.WeatherReport.weather[0].main);
        }

        [Test]
        public void Attribute_Weather_Description_Value_Test()
        {
            Assert.AreEqual("broken clouds", service.weatherDTO.WeatherReport.weather[0].description);
        }

        [Test]
        public void Attribute_Weather_Icon_Value_Test()
        {
            Assert.AreEqual("04d", service.weatherDTO.WeatherReport.weather[0].icon);
        }

        [Test]
        public void Attribute_Weather_Id_DataType_Test()
        {
            Assert.AreEqual(803.GetType(), service.weatherDTO.WeatherReport.weather[0].id.GetType());
        }

        [Test]
        public void Attribute_Weather_Main_DataType_Test()
        {
            Assert.AreEqual("Clouds".GetType(), service.weatherDTO.WeatherReport.weather[0].main.GetType());
        }

        [Test]
        public void Attribute_Weather_Description_DataType_Test()
        {
            Assert.AreEqual("broken clouds".GetType(), service.weatherDTO.WeatherReport.weather[0].description.GetType());
        }

        [Test]
        public void Attribute_Weather_Icon_DataType_Test()
        {
            Assert.AreEqual("04d".GetType(), service.weatherDTO.WeatherReport.weather[0].icon.GetType());
        }

        [Test]
        public void Attribute_Base_Value_Test()
        {
            Assert.AreEqual("stations", service.weatherDTO.WeatherReport.@base);
        }

        [Test]
        public void Attribute_Base_DataType_Test()
        {
            Assert.AreEqual("stations".GetType(), service.weatherDTO.WeatherReport.@base.GetType());
        }

        [Test]
        public void Attribute_Main_Temp_Value_Test()
        {
            Assert.AreEqual(285.5, service.weatherDTO.WeatherReport.main.temp);
        }

        [Test]
        public void Attribute_Main_Pressure_Value_Test()
        {
            Assert.AreEqual(1004, service.weatherDTO.WeatherReport.main.pressure);

        }

        [Test]
        public void Attribute_Main_Humidity_Value_Test()
        {
            Assert.AreEqual(71, service.weatherDTO.WeatherReport.main.humidity);

        }

        [Test]
        public void Attribute_Main_Temp_Min_Value_Test()
        {
            Assert.AreEqual(284.15, service.weatherDTO.WeatherReport.main.temp_min);

        }

        [Test]
        public void Attribute_Main_Temp_Max_Value_Test()
        {
            Assert.AreEqual(287.04, service.weatherDTO.WeatherReport.main.temp_max);
        }

        [Test]
        public void Attribute_Main_Temp_DataType_Test()
        {
            Assert.AreEqual((271.01).GetType(), service.weatherDTO.WeatherReport.main.temp.GetType());
        }


        [Test]
        public void Attribute_Main_Pressure_DataType_Test()
        {
            Assert.AreEqual(71.GetType(), service.weatherDTO.WeatherReport.main.pressure.GetType());
        }

        [Test]
        public void Attribute_Main_Humidity_DataType_Test()
        {
            Assert.AreEqual(71.GetType(), service.weatherDTO.WeatherReport.main.humidity.GetType());
        }

        [Test]
        public void Attribute_Main_Temp_Min_DataType_Test()
        {
            Assert.AreEqual((271.01).GetType(), service.weatherDTO.WeatherReport.main.temp_min.GetType());
        }

        [Test]
        public void Attribute_Main_Temp_Max_DataType_Test()
        {
            Assert.AreEqual((290.00).GetType(), service.weatherDTO.WeatherReport.main.temp_max.GetType());
        }

        [Test]
        public void Attribute_Visibility_Test()
        {

        }

        [Test]
        public void Attribute_Wind_Test()
        {

        }

        [Test]
        public void Attribute_Clouds_Test()
        {

        }

        [Test]
        public void Attribute_Dt_Test()
        {

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
