using ecommerceflyout.Models;
using ecommerceflyout.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ecommerceflyout.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramsandFeatures : ContentPage
    {
        private ObservableCollection<User> Users;
        public ProgramsandFeatures()
        {
            InitializeComponent();
            LoadData();
           
        }


        public async void LoadData()
        {
            Users = await new APIService().RefreshAsyncData();
            UsersList.ItemsSource = Users;

        }
    }
}