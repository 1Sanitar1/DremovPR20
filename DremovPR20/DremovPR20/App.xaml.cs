using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DremovPR20.Services;
using DremovPR20.Views;

namespace DremovPR20
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
