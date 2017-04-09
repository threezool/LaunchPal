using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaunchPal.Views;
using Xamarin.Forms;

namespace LaunchPal
{
    public class App : Application
    {
        public App()
        {
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps

        }

        protected override void OnResume()
        {
            // Handle when your app resumes

        }
    }
}
