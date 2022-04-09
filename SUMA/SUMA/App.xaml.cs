using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SUMA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SUMA()
            {

            };
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
