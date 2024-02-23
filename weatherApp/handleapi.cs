using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace weatherApp
{
    public class WeatherService
    {
        private const string ApiKey = "f555c408ac9572f48a3311523b3084b9";
        private const string BaseUrl = "https://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}";

        public async Task<WeatherData> GetWeatherAsync(string city)
        {
            using (var client = new HttpClient())
            {
                var url = string.Format(BaseUrl, city, ApiKey);
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<WeatherData>(json);
                }
                return null;
            }
        }
    }

}
