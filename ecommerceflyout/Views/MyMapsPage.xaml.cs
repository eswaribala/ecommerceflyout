using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ecommerceflyout.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMapsPage : ContentPage
    {
        public MyMapsPage()
        {
            InitializeComponent();
        }

        private async void MyLocation_Clicked(object sender, EventArgs e)
        {
            try
            {
                var yourLocation = await Geolocation.GetLocationAsync(new GeolocationRequest()
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromSeconds(30)
                });

                if (yourLocation == null)
                    await DisplayAlert("Attention", "GPS is not available", "Ok");
                else
                    Latitude.Text = $"{yourLocation.Latitude}";
                    Longitude.Text = $"{yourLocation.Longitude}";
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ooops!", $"Something went wrong: {ex.Message}", "Ok");
            }

        }
    }
}