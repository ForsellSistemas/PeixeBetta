using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PeixeBetta
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PeixeBetta.MainPage());
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
