using System;
using System.Collections.Generic;
using System.Text;
using WPFSchedulerTests;
using NUnit.Framework;
using System.Threading.Tasks;
using WeatherAPILibrary;
using System.Net;


namespace WPFSchedulerTests
{
    [TestFixture]
    public class WeatherAPITests
    {
        [Test]
        public async void ShouldContainCorrectData()
        {
            string cityName = "Wrocław";
            WeatherAPIHelper.InitializeClient();
            WeatherAPIResponse response =await WeatherProcessor.GetWeather(cityName);
            Assert.AreEqual(cityName, response.Name);
        }
    }
}
