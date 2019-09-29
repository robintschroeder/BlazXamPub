using System.Collections.ObjectModel;
using MSC.BlazXam.Xam.Models;

namespace MSC.BlazXam.Xam.ViewModelsDesign
{
    public static class ViewModelLocator
    {
        private static ItemsViewModel_2 _itemsViewModel_2;
        private static ItemsViewModel_Empty _itemsViewModel_Empty;

        public static ItemsViewModel_2 ItemsViewModel_2 =>
           _itemsViewModel_2 ?? (_itemsViewModel_2 = new ItemsViewModel_2());

        public static ItemsViewModel_Empty ItemsViewModel_Empty =>
           _itemsViewModel_Empty ?? (_itemsViewModel_Empty = new ItemsViewModel_Empty());
    }

    public class ItemsViewModel_2
    {
        public bool IsShowEmptyItemsListMessage
        {
            get { return false; }
        }

        public ObservableCollection<Item> Items
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

        public string ItemsPageMessage
        {
            get
            {
                return string.Empty;
            }
        }
    }

    public class ItemsViewModel_Empty
    {
        public bool IsShowEmptyItemsListMessage
        {
            get { return true; }
        }

        public ObservableCollection<Item> Items
        {
            get
            {
                return new ObservableCollection<Item>();
            }
        }

        public string ItemsPageMessage
        {
            get
            {
                return "Sample ItemsPageMessage";
            }
        }
    }
}