using ecommerceflyout.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ecommerceflyout.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}