using ecommerceflyout.Services;
using ecommerceflyout.Themes;
using ecommerceflyout.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ecommerceflyout
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
         //   ThemeManager.ChangeTheme("Default");
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
