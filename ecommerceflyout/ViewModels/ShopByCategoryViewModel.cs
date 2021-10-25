using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ecommerceflyout.ViewModels
{
    public class ShopByCategoryViewModel : BaseViewModel
    {
        public ShopByCategoryViewModel()
        {
            Title = "Shop By Category";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}