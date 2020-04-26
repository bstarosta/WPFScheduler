using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WeatherAPILibrary
{
    public static class WeatherAPIHelper
    {
        public static HttpClient WeatherAPIClient { get; set; }

        public static void InitializeClient()
        {
            WeatherAPIClient = new HttpClient
            {
                BaseAddress = new Uri("http://api.openweathermap.org/data/2.5/")
            };
            WeatherAPIClient.DefaultRequestHeaders.Accept.Clear();
            WeatherAPIClient.Timeout = TimeSpan.FromSeconds(20);
            WeatherAPIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
