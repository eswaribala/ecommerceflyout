using ecommerceflyout.Themes;
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
    public partial class NetworkPage : ContentPage
    {

        private NetworkAccess CurrentAccess;
        private IEnumerable<ConnectionProfile> Profiles;


        public NetworkPage()
        {
            InitializeComponent();

            themePicker.SelectedIndexChanged += ThemePicker_SelectedIndexChanged;

           

            CurrentAccess = Connectivity.NetworkAccess;

            Profiles = Connectivity.ConnectionProfiles;
            //tracing dynamic changes in network
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
            if(CurrentAccess == NetworkAccess.Internet)
            {
                NetworkType.Text = "Available Network is Internet";
            }
            if (CurrentAccess == NetworkAccess.Local)
            {
                NetworkType.Text = "Available Network is Local";
            }

            if (Profiles.Contains(ConnectionProfile.WiFi))
            {
                NetworkTProfile.Text = "Network Profile is WIFI";
            }
            if (Profiles.Contains(ConnectionProfile.Ethernet))
            {
                NetworkTProfile.Text = "Network Profile is Ethernet";
            }

        }

        private void ThemePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemeManager.ChangeTheme(themePicker.SelectedItem.ToString());
        }

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            CurrentAccess = Connectivity.NetworkAccess;
            Profiles= Connectivity.ConnectionProfiles;
        }
    }
}