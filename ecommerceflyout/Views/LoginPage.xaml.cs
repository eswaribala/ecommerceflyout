using ecommerceflyout.ViewModels;
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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            var vm = new MemberLoginViewModel();
            this.BindingContext = vm;
            vm.InValidLoginPrompt += () => DisplayAlert("Login Status", "Login Failed", "Dismiss");
            vm.ValidLoginPrompt += () =>
            {
                Navigation.PushAsync(new ShopByCategory());
            };


            Email.Completed += (object sender, EventArgs e) =>
            {
                Password.Focus();
            };

            Password.Completed += (object sender, EventArgs e) =>
            {
                vm.SubmitCommand.Execute(null);
            };
        }
    }
}