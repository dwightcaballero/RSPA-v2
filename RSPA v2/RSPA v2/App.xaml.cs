using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RSPA_v2.Services;
using RSPA_v2.Views;

namespace RSPA_v2
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
