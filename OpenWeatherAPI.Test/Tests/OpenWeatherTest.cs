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
        public void Attribute_Coord_Test()
        {
            Assert.AreEqual(-0.13, service.weatherDTO.WeatherReport.coord.lon);
            Assert.AreEqual(51.51, service.weatherDTO.WeatherReport.coord.lat);
        }

        [Test]
        public void Attribute_Weather_Test()
        {
            Assert.AreEqual(803, service.weatherDTO.WeatherReport.weather[0].id);
            Assert.AreEqual("Clouds", service.weatherDTO.WeatherReport.weather[0].main);
            Assert.AreEqual("broken clouds", service.weatherDTO.WeatherReport.weather[0].description);
            Assert.AreEqual("04d", service.weatherDTO.WeatherReport.weather[0].icon);
        }

        [Test]
        public void Attribute_Base_Test()
        {

        }

        [Test]
        public void Attribute_Main_Test()
        {

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
