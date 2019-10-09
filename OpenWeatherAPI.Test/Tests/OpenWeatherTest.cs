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
        public void Coord_Test()
        {
            Assert.AreEqual(-0.13, service.weatherDTO.WeatherReport.coord.lon);
            Assert.AreEqual(51.51,service.weatherDTO.WeatherReport.coord.lat);
            //Assert.AreEqual(-0.13, Double.Parse(service.weatherReportJson["coord"]["lon"].ToString()));
        }
    }
}
