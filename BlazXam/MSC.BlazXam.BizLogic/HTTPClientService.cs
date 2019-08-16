using MSC.BlazXam.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace MSC.BlazXam.BizLogic
{
    public static class HTTPClientService
    {
        public static async Task<AccuWeatherCurrentConditModel> GetAccuWeatherCurrentConditionsDataAsync(string locationId)
        {
            var locData = new AccuWeatherCurrentConditModel();

            try
            {
                HttpClient client = new HttpClient();
                client.MaxResponseContentBufferSize = 256000;
                var urlStr = $"https://dataservice.accuweather.com/currentconditions/v1/{locationId}?apikey={Config.AccuWeatherKey}&language=en-us&details=false ";
                var uri = new Uri(urlStr);
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var list = JsonConvert.DeserializeObject<List<AccuWeatherCurrentConditModel>>(content);
                    if (list.Count == 1) { locData = list[0]; }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ERROR { ex.Message}");
                //TODO: log error here with your favorite logging tool
            }

            return locData;
        }

        public static async Task<IList<AccuWeatherTopCitiesModel>> GetAccuWeatherTopCitiesDataAsync()
        {
            var locData = new List<AccuWeatherTopCitiesModel>();

            try
            {
                HttpClient client = new HttpClient();
                client.MaxResponseContentBufferSize = 256000;
                var urlStr = $"https://dataservice.accuweather.com/locations/v1/topcities/50?apikey={Config.AccuWeatherKey}&language=en-us&details=true";
                var uri = new Uri(urlStr);
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    locData = JsonConvert.DeserializeObject<List<AccuWeatherTopCitiesModel>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ERROR { ex.Message}");
                //TODO: log error here with your favorite logging tool
            }

            Debug.WriteLine($"SUCCESS Retrieved {locData.Count} Records");

            return locData;
        }
    }
}