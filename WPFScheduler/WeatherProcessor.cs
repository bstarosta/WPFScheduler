using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WPFScheduler
{
    public class WeatherProcessor
    {
        public async Task<WeatherAPIResponse> GetWeather()
        {

            string url = "http://api.openweathermap.org/data/2.5/weather?q={Wroc%C5%82aw}&appid={2ab8da9038bfa89ee9cbf1750cf81907}";

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
