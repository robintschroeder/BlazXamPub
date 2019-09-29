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
        private bool _isShowEmptyItemsListMessage;
        private ObservableCollection<Item> _items;
        private string _itemsPageMessage;

        public ItemsViewModel()
        {
            Title = "Browse";
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        public bool IsShowEmptyItemsListMessage
        {
            get { return _isShowEmptyItemsListMessage; }
            set { SetProperty(ref _isShowEmptyItemsListMessage, value); }
        }

        public ObservableCollection<Item> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        public string ItemsPageMessage
        {
            get { return _itemsPageMessage; }
            set { SetProperty(ref _itemsPageMessage, value); }
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

                if (Items.Count == 0)
                {
                    IsShowEmptyItemsListMessage = true;
                    ItemsPageMessage = "No Cities Returned! API only allows 50 calls per day!";
                }
                else
                {
                    IsShowEmptyItemsListMessage = false;
                    ItemsPageMessage = string.Empty;
                }
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