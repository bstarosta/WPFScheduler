using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WeatherAPILibrary
{
    /// <summary>
    /// Klasa wspomagająca obsługę API pogodowego. Zawera statyczny obiekt <c>HttpClient</c> oraz
    /// metodę inicializującą ten obiekt
    /// </summary>
    public static class WeatherAPIHelper
    {
        ///<value>Obiekt odpowiedzialny za komunikacje z API </value>
        public static HttpClient WeatherAPIClient { get; set; }

        /// <summary>
        /// Metoda statyczna inicjalizująca klienta http
        /// </summary>
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
