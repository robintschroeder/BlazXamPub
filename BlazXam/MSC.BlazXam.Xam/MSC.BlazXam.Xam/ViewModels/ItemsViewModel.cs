using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using MSC.BlazXam.Xam.Models;
using MSC.BlazXam.Xam.Views;

namespace MSC.BlazXam.Xam.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        private string itemsPageMessage = string.Empty;

        public ItemsViewModel()
        {
            Title = "Browse";
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        public ObservableCollection<Item> Items { get; set; }

        public string ItemsPageMessage
        {
            get { return itemsPageMessage; }
            set { SetProperty(ref itemsPageMessage, value); }
        }

        public Command LoadItemsCommand { get; set; }

        private async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
                ItemsPageMessage = (Items.Count == 0) ? "No Cities Returned! API only allows 50 calls per day!" : string.Empty;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}