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
        [Test]
        public void AttributeCoordLonDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.coord.lon);
        }

        [Test]
        public void AttributeCoordLonDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.coord.lon);
        }

        [Test]
        public void AttributeCoordLatDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.coord.lat);
        }

        [Test]
        public void AttributeCoordLatDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.coord.lat);
        }


        [Test]
        public void AttributeWeatherIdDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.weather[0].id);
        }

        [Test]
        public void AttributeWeatherIdDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(double), service.weatherDTO.WeatherReport.weather[0].id);
        }

        [Test]
        public void AttributeWeatherIdRangeTest01()
        {
            Assert.GreaterOrEqual(service.weatherDTO.WeatherReport.weather[0].id, 0);
        }

        [Test]
        public void AttributeWeatherMainDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.WeatherReport.weather[0].main);
        }

        [Test]
        public void AttributeWeatherMainDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(char), service.weatherDTO.WeatherReport.weather[0].main);
        }

        [Test]
        public void AttributeWeatherMainLengthTest01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.weather[0].main.Length, 0);
        }

        [Test]
        public void AttributeWeatherDescriptionDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.WeatherReport.weather[0].description);
        }

        [Test]
        public void AttributeWeatherDescriptionDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(int), service.weatherDTO.WeatherReport.weather[0].description);
        }

        [Test]
        public void AttributeWeatherDescriptionLengthTest01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.weather[0].description.Length, 0);
        }

        [Test]
        public void AttributeWeatherIconDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.WeatherReport.weather[0].icon);
        }

        [Test]
        public void AttributeWeatherIconDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(double), service.weatherDTO.WeatherReport.weather[0].icon);
        }

        [Test]
        public void AttributeWeatherIconLengthTest01()
        {
            Assert.GreaterOrEqual(service.weatherDTO.WeatherReport.weather[0].icon.Length, 0);
        }

        [Test]
        public void AttributeBaseDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.WeatherReport.@base);
        }

        [Test]
        public void AttributeBaseDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(bool), service.weatherDTO.WeatherReport.@base);
        }

        [Test]
        public void AttributeBaseLengthTest01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.@base.Length, 0);
        }

        [Test]
        public void AttributeMainTempDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.main.temp);
        }

        [Test]
        public void AttributeMainTempDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(char), service.weatherDTO.WeatherReport.main.temp);
        }

        [Test]
        public void AttributeMainTempRangeTest01()
        {
            Assert.GreaterOrEqual(service.weatherDTO.WeatherReport.main.temp, service.weatherDTO.WeatherReport.main.temp_min);
        }

        [Test]
        public void AttributeMainTempRangeTest02()
        {
            Assert.LessOrEqual(service.weatherDTO.WeatherReport.main.temp, service.weatherDTO.WeatherReport.main.temp_max);
        }

        [Test]
        public void AttributeMainPressureDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.main.pressure);
        }

        [Test]
        public void AttributeMainPressureDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(long), service.weatherDTO.WeatherReport.main.pressure);
        }

        [Test]
        public void AttributeMainPressureRangeTest01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.main.pressure, 0);
        }

        [Test]
        public void AttributeMainHumidityDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.main.humidity);
        }

        [Test]
        public void AttributeMainHumidityDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(double), service.weatherDTO.WeatherReport.main.humidity);
        }

        [Test]
        public void AttributeMainHumidityRangeTest01()
        {
            Assert.GreaterOrEqual(service.weatherDTO.WeatherReport.main.humidity, 0);
        }

        [Test]
        public void AttributeMainTempMinDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.main.temp_min);
        }

        [Test]
        public void AttributeMainTempMinDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.main.temp_min);
        }

        [Test]
        public void AttributeMainTempMinRangeTest01()
        {
            //tempmin should be less than or equal to tempmax
            Assert.LessOrEqual(service.weatherDTO.WeatherReport.main.temp_min, service.weatherDTO.WeatherReport.main.temp_max);
        }

        [Test]
        public void AttributeMainTempMaxDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.main.temp_max);
        }

        [Test]
        public void AttributeMainTempMaxDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(int), service.weatherDTO.WeatherReport.main.temp_max);
        }

        [Test]
        public void AttributeMainSeaLevelDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.main.sea_level);
        }

        [Test]
        public void AttributeMainSeaLevelDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(short), service.weatherDTO.WeatherReport.main.sea_level);
        }

        [Test]
        public void AttributeMainGrndLevelDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.main.grnd_level);
        }

        [Test]
        public void AttributeMainGrndLevelDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(char), service.weatherDTO.WeatherReport.main.grnd_level);
        }

        [Test]
        public void AttributeVisibilityDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.visibility);
        }

        [Test]
        public void AttributeVisibilityDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.visibility);
        }

        [Test]
        public void AttributeVisibilityRangeTest01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.visibility, 0);
        }

        [Test]
        public void AttributeWindSpeedDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.wind.speed);
        }

        [Test]
        public void AttributeWindSpeedDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(bool), service.weatherDTO.WeatherReport.wind.speed);
        }

        [Test]
        public void AttributeWindSpeedRangeTest()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.wind.speed, 0);
        }

        [Test]
        public void AttributeWindDegDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.wind.deg);
        }

        [Test]
        public void AttributeWindDegDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.wind.deg);
        }

        [Test]
        public void AttributeWindDegRangeTest01()
        {
            Assert.GreaterOrEqual(service.weatherDTO.WeatherReport.wind.deg, 0);
        }

        [Test]
        public void AttributeWindDegRangeTest02()
        {
            Assert.LessOrEqual(service.weatherDTO.WeatherReport.wind.deg, 360);
        }

        [Test]
        public void AttributeCloudsAllDataTypeTest01()
        {

            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.clouds.all);
        }

        [Test]
        public void AttributeCloudsAllDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(short), service.weatherDTO.WeatherReport.clouds.all);
        }

        [Test]
        public void AttributeDtDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.dt);
        }

        [Test]
        public void AttributeDtDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(double), service.weatherDTO.WeatherReport.dt);
        }

        [Test]
        public void AttributeSysTypeDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.sys.type);
        }

        [Test]
        public void AttributeSysTypeDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(bool), service.weatherDTO.WeatherReport.sys.type);
        }

        [Test]
        public void AttributeSysIdDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.sys.id);
        }

        [Test]
        public void AttributeSysIdDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(char), service.weatherDTO.WeatherReport.sys.id);
        }

        [Test]
        public void AttributeSysMessageDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.sys.message);
        }

        [Test]
        public void AttributeSysMessageDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.sys.message);
        }

        [Test]
        public void AttributeSysCountryDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.WeatherReport.sys.country);
        }

        [Test]
        public void AttributeSysCountryDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(double), service.weatherDTO.WeatherReport.sys.country);
        }

        [Test]
        public void AttributeSysCountryLengthTest01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.sys.country.Length, 0);
        }

        [Test]
        public void AttributeSysSunriseDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.sys.sunrise);
        }

        [Test]
        public void AttributeSysSunriseDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(short), service.weatherDTO.WeatherReport.sys.sunrise);
        }

        [Test]
        public void AttributeSysSunriseRangeTest01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.sys.sunrise, 0);
        }

        [Test]
        public void AttributeSysSunsetDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.sys.sunset);
        }

        [Test]
        public void AttributeSysSunsetDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(long), service.weatherDTO.WeatherReport.sys.sunset);
        }

        [Test]
        public void AttributeSysSunsetRangeTest01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.sys.sunset, 0);
        }

        [Test]
        public void AttributeRain1hDataTypeTest01()
        {
            //Rain maybe null if weather is not rainning. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.rain != null)
            {
                Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.rain.oneHour);
            }
        }

        [Test]
        public void AttributeRain1hDataTypeTest02()
        {
            //Rain maybe null if weather is not rainning. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.rain != null)
            {
                Assert.IsNotInstanceOf(typeof(char), service.weatherDTO.WeatherReport.rain.oneHour);
            }
        }

        [Test]
        public void AttributeRain1hRangeTest01()
        {
            //Rain maybe null if weather is not rainning. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.rain != null)
            {
                Assert.Greater(service.weatherDTO.WeatherReport.rain.oneHour, 0.0);
            }
        }

        [Test]
        public void AttributeRain3hDataTypeTest01()
        {
            //Rain maybe null if weather is not rainning. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.rain != null)
            {
                Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.rain.threeHour);
            }
        }

        [Test]
        public void AttributeRain3hDataTypeTest02()
        {
            //Rain maybe null if weather is not rainning. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.rain != null)
            {
                Assert.IsNotInstanceOf(typeof(int), service.weatherDTO.WeatherReport.rain.threeHour);
            }
        }

        [Test]
        public void AttributeRain3hRnageTest01()
        {
            //Rain maybe null if weather is not rainning. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.rain != null)
            {
                Assert.Greater(service.weatherDTO.WeatherReport.rain.threeHour, 0.0);
            }
        }

        [Test]
        public void AttributeSnow1hDataTypeTest01()
        {
            //Snow maybe null if weather is not snow. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.snow != null)
            {
                Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.snow.oneHour);
            }
        }

        [Test]
        public void AttributeSnow1hDataTypeTest02()
        {
            //Snow maybe null if weather is not snow. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.snow != null)
            {
                Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.snow.oneHour);
            }
        }

        [Test]
        public void AttributeSnow1hRangeTest01()
        {
            //Snow maybe null if weather is not snow. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.snow != null)
            {
                Assert.Greater(service.weatherDTO.WeatherReport.snow.oneHour, 0.0);
            }
        }

        [Test]
        public void AttributeSnow3hDataTypeTest01()
        {
            //Snow maybe null if weather is not snow. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.snow != null)
            {
                Assert.IsInstanceOf(typeof(double), service.weatherDTO.WeatherReport.snow.threeHour);
            }
        }

        [Test]
        public void AttributeSnow3hDataTypeTest02()
        {
            //Snow maybe null if weather is not snow. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.snow != null)
            {
                Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.snow.threeHour);
            }
        }

        [Test]
        public void AttributeSnow3hRangeTest01()
        {
            //Snow maybe null if weather is not snow. The attribute will not be contained in the result
            if (service.weatherDTO.WeatherReport.snow != null)
            {
                Assert.Greater(service.weatherDTO.WeatherReport.snow.threeHour, 0.0);
            }
        }

        [Test]
        public void AttributeTimezoneDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.timezone);
        }

        [Test]
        public void AttributeTimezoneDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.WeatherReport.timezone);
        }

        [Test]
        public void AttributeIdDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.id);
        }

        [Test]
        public void AttributeIdDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(double), service.weatherDTO.WeatherReport.id);
        }

        [Test]
        public void AttributeIdRangeTest01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.id, 0);
        }

        [Test]
        public void AttributeNameDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.WeatherReport.name);
        }

        [Test]
        public void AttributeNameDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(int), service.weatherDTO.WeatherReport.name);
        }

        [Test]
        public void AttributeNameLengthTest01()
        {
            Assert.Greater(service.weatherDTO.WeatherReport.name.Length, 0);
        }

        [Test]
        public void AttributeCodDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.WeatherReport.cod);
        }

        [Test]
        public void AttributeCodDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(bool), service.weatherDTO.WeatherReport.cod);
        }

        [Test]
        public void HeaderConnectionDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.ReportHeader.Connection);
        }

        [Test]
        public void HeaderConnectionDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(char), service.weatherDTO.ReportHeader.Connection);
        }

        [Test]
        public void HeaderConnectionValueTest01()
        {
            Assert.AreEqual("keep-alive", service.weatherDTO.ReportHeader.Connection);
        }

        [Test]
        public void HeaderConnectionValueTest02()
        {
            Assert.AreNotEqual("alive", service.weatherDTO.ReportHeader.Connection);
        }

        [Test]
        public void HeaderConnectionLengthTest01()
        {
            Assert.Greater(service.weatherDTO.ReportHeader.Connection.Length, 0);
        }

        [Test]
        public void HeaderAccessControlAllowOriginDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.ReportHeader.Access_Control_Allow_Origin);
        }

        [Test]
        public void HeaderAccessControlAllowOriginDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(int), service.weatherDTO.ReportHeader.Access_Control_Allow_Origin);
        }

        [Test]
        public void HeaderAccessControlAllowOriginValueTest01()
        {
            Assert.AreEqual("*", service.weatherDTO.ReportHeader.Access_Control_Allow_Origin);
        }

        [Test]
        public void HeaderAccessControlAllowOriginValueTest02()
        {
            Assert.AreNotEqual("All", service.weatherDTO.ReportHeader.Access_Control_Allow_Origin);
        }

        [Test]
        public void HeaderAccessControlAllowOriginLengthTest01()
        {
            Assert.Greater(service.weatherDTO.ReportHeader.Access_Control_Allow_Origin.Length, 0);
        }

        [Test]
        public void HeaderAccessControlAllowCredentialsDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(bool), service.weatherDTO.ReportHeader.Access_Control_Allow_Credentials);
        }

        [Test]
        public void HeaderAccessControlAllowCredentialsDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.ReportHeader.Access_Control_Allow_Credentials);
        }

        [Test]
        public void HeaderAccessControlAllowCredentialsValueTest01()
        {
            Assert.AreEqual(true, service.weatherDTO.ReportHeader.Access_Control_Allow_Credentials);
        }

        [Test]
        public void HeaderAccessControlAllowCredentialsValueTest02()
        {
            Assert.AreNotEqual(false, service.weatherDTO.ReportHeader.Access_Control_Allow_Credentials);
        }

        [Test]
        public void HeaderAccessControlAllowMethodsDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.ReportHeader.Access_Control_Allow_Methods);
        }

        [Test]
        public void HeaderAccessControlAllowMethodsDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(bool), service.weatherDTO.ReportHeader.Access_Control_Allow_Methods);
        }

        [Test]
        public void HeaderAccessControlAllowMethodsValueTest01()
        {
            Assert.AreEqual("GET, POST", service.weatherDTO.ReportHeader.Access_Control_Allow_Methods);
        }

        [Test]
        public void HeaderAccessControlAllowMethodsValueTest02()
        {
            Assert.AreNotEqual("GET", service.weatherDTO.ReportHeader.Access_Control_Allow_Methods);
        }

        [Test]
        public void HeaderAccessControlAllowMethodsLengthTest01()
        {
            Assert.Greater(service.weatherDTO.ReportHeader.Access_Control_Allow_Methods.Length, 0);
        }

        [Test]
        public void HeaderXCacheKeyDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.ReportHeader.X_Cache_Key);
        }

        [Test]
        public void HeaderXCacheKeyDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(int), service.weatherDTO.ReportHeader.X_Cache_Key);
        }

        [Test]
        public void HeaderXCacheKeyLengthTest01()
        {
            Assert.Greater(service.weatherDTO.ReportHeader.X_Cache_Key.Length, 0);
        }

        [Test]
        public void HeaderContentLengthDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(int), service.weatherDTO.ReportHeader.Content_Length);
        }

        [Test]
        public void HeaderContentLengthDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(string), service.weatherDTO.ReportHeader.Content_Length);
        }

        [Test]
        public void HeaderContentLengthRangeTest01()
        {
            Assert.Greater(service.weatherDTO.ReportHeader.Content_Length, 0);
        }

        [Test]
        public void HeaderContentTypeDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.ReportHeader.Content_Type);
        }

        [Test]
        public void HeaderContentTypeDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(bool), service.weatherDTO.ReportHeader.Content_Type);
        }

        [Test]
        public void HeaderContentTypeValueTest01()
        {
            Assert.AreEqual("application/json; charset=utf-8", service.weatherDTO.ReportHeader.Content_Type);
        }

        [Test]
        public void HeaderContentTypeValueTest02()
        {
            Assert.AreNotEqual("application/xml;charset=utf-8", service.weatherDTO.ReportHeader.Content_Type);
        }

        [Test]
        public void HeaderContentTypeLengthTest01()
        {
            Assert.Greater(service.weatherDTO.ReportHeader.Content_Type.Length, 0);
        }

        [Test]
        public void HeaderServerDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.ReportHeader.Server);
        }

        [Test]
        public void HeaderServerDataTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(int), service.weatherDTO.ReportHeader.Server);
        }

        [Test]
        public void HeaderServerValueTest01()
        {
            Assert.AreEqual("openresty", service.weatherDTO.ReportHeader.Server);
        }

        [Test]
        public void HeaderServerValueTest02()
        {
            Assert.AreNotEqual("Microsoft-IIS/8,5", service.weatherDTO.ReportHeader.Server);
        }

        [Test]
        public void HeaderServerLengthTest01()
        {
            Assert.Greater(service.weatherDTO.ReportHeader.Server.Length, 0);
        }

        [Test]
        public void HeaderDateDataTypeTest01()
        {
            Assert.IsInstanceOf(typeof(string), service.weatherDTO.ReportHeader.Date);
        }

        [Test]
        public void HeaderDateDateTypeTest02()
        {
            Assert.IsNotInstanceOf(typeof(DateTime), service.weatherDTO.ReportHeader.Date);
        }

        [Test]
        public void HeaderDateFormatTest01()
        {
            //format: Web dd OCT yyyy hh:mm:ss UDA
            string format = "([A-Z][a-z][a-z],) ([0-9][0-9])..([A-z])..[0-2][0-9][0-9][0-9] [0-2][0-9]:[0-6][0-9]:[0-6][0-9]..[A-Z][A-Z]";
            Assert.AreEqual(true, Regex.Match(service.weatherDTO.ReportHeader.Date, format).Success);
        }

        [Test]
        public void HeaderDateLengthTest01()
        {
            Assert.Greater(service.weatherDTO.ReportHeader.Date.Length, 0);
        }

        [Test]
        public void ResponseStatusTest01()
        {
            Assert.AreEqual(HttpStatusCode.OK, service.statusCode);
        }

        [Test]
        public void ResponseStatusTest02()
        {
            Assert.AreNotEqual(HttpStatusCode.NotFound, service.statusCode);
        }
    }
}
