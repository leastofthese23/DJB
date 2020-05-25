using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DJB.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DJB
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("android=ec66f94e-c700-46ad-b013-753d0d93b517;" +
                  "uwp=662b4d05-073b-4caf-8a9c-23f9756d6447;",
                  typeof(Analytics), typeof(Crashes));
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
