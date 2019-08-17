using System;
using MSC.BlazXam.Models;
using MSC.BlazXam.Xam.Models;

namespace MSC.BlazXam.Xam.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        private string city;
        private string country;
        private AccuWeatherCurrentConditModel currentWeather;

        public ItemDetailViewModel()
        {
        }

        public string City
        {
            get { return city; }
            set { SetProperty(ref city, value); }
        }

        public string Country
        {
            get { return country; }
            set { SetProperty(ref country, value); }
        }

        public AccuWeatherCurrentConditModel CurrentWeather
        {
            get { return currentWeather; }
            set { SetProperty(ref currentWeather, value); }
        }

        public async void Init(string id, string city, string country)
        {
            CurrentWeather = await MSC.BlazXam.BizLogic.HTTPClientService.GetAccuWeatherCurrentConditionsDataAsync(id);
            City = city;
            Country = country;
        }
    }
}