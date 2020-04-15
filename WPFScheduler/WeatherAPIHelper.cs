using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WPFScheduler
{
    public static class WeatherAPIHelper
    {
        public static HttpClient WeatherAPIClient { get; set; }

        public static void InitializeClient()
        {
            WeatherAPIClient = new HttpClient();
            WeatherAPIClient.DefaultRequestHeaders.Accept.Clear();
            WeatherAPIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
