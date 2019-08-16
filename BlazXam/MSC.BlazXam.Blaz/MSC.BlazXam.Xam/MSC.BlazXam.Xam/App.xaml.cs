using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MSC.BlazXam.Xam.Services;
using MSC.BlazXam.Xam.Views;

namespace MSC.BlazXam.Xam
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<APIDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }
    }
}