using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MSC.BlazXam.Xam.Models;
using MSC.BlazXam.Xam.ViewModels;

namespace MSC.BlazXam.Xam.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        private ItemDetailViewModel viewModel = new ItemDetailViewModel();

        public ItemDetailPage(string id, string city, string country)
        {
            InitializeComponent();
            viewModel.Init(id, city, country);
            BindingContext = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();
            viewModel.Init("349727", "New York", "United States");
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}