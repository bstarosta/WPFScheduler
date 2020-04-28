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
        public static async Task<WeatherAPIResponse> GetWeather(string cityName)
        {

            string url = $"weather?q={cityName}&units=metric&appid=2ab8da9038bfa89ee9cbf1750cf81907";

            using (HttpResponseMessage response = await WeatherAPIHelper.WeatherAPIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    WeatherAPIResponse weather = await response.Content.ReadAsAsync<WeatherAPIResponse>();
                    return weather;
                }
                else
                    throw new Exception(response.ReasonPhrase);
            }
        }

    }
}
