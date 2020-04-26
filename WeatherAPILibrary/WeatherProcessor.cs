using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPILibrary
{
    public class WeatherProcessor
    {
        public static WeatherAPIResponse GetWeather(string cityName)
        {

            string url = $"weather?q={cityName}&units=metric&appid=2ab8da9038bfa89ee9cbf1750cf81907";

            using (HttpResponseMessage response = WeatherAPIHelper.WeatherAPIClient.GetAsync(url).GetAwaiter().GetResult())
            {
                if (response.IsSuccessStatusCode)
                {
                    WeatherAPIResponse weather =response.Content.ReadAsAsync<WeatherAPIResponse>().GetAwaiter().GetResult();
                    return weather;
                }
                else
                    throw new Exception(response.ReasonPhrase);
            }
        }

    }
}
