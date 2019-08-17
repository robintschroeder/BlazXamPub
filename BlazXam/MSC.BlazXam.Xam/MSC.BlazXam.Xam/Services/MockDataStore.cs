using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSC.BlazXam.Xam.Models;

namespace MSC.BlazXam.Xam.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        private List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item() { Id = "123456", City = "New York", Country = "United States" },
                new Item() { Id = "789456", City = "Paris", Country = "France" }
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}