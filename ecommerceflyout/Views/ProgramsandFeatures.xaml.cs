using ecommerceflyout.Services;
using System;
using System.Collections.Generic;
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
        public ProgramsandFeatures()
        {
            InitializeComponent();

            new APIService().RefreshAsyncData();
        }
    }
}