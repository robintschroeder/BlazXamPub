using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using MSC.BlazXam.Xam.Models;
using MSC.BlazXam.Xam.Views;
using MSC.BlazXam.Xam.ViewModels;

namespace MSC.BlazXam.Xam.ViewModelsDesign
{
    public static class ItemsViewModel
    {
        public static ObservableCollection<Item> Items
        {
            get
            {
                return new ObservableCollection<Item>()
                {
                    new Item() { Id = "123456", City = "New York", Country = "United States" , Population = 123456789 },
                    new Item() { Id = "789456", City = "Paris", Country = "France" , Population = 987654321 }
                };
            }
        }

        public static string ItemsPageMessage
        {
            get
            {
                return "Sample ItemsPageMessage";
            }
        }
    }
}