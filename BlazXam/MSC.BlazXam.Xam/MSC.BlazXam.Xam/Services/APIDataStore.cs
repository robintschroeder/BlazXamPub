using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSC.BlazXam.BizLogic;
using MSC.BlazXam.Xam.Models;

namespace MSC.BlazXam.Xam.Services
{
    public class APIDataStore : IDataStore<Item>
    {
        Task<Item> IDataStore<Item>.GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<Item>> IDataStore<Item>.GetItemsAsync(bool forceRefresh)
        {
            var items = new List<Item>();

            var topCities = await HTTPClientService.GetAccuWeatherTopCitiesDataAsync();
            foreach (var city in topCities)
            {
                items.Add(new Item()
                {
                    Id = city.Key,
                    City = city.EnglishName,
                    Country = city.Country.EnglishName,
                    Population = city.Details.Population
                });
            }

            return items;
        }
    }
}