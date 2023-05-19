using Delivery.Views.MainMenu;
using Delivery.Views.Detail;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Delivery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ProductDetail();
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
