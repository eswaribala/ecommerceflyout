using ecommerceflyout.Models;
using ecommerceflyout.Persistence;
using SQLite;
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

    public partial class RegistrationPage : ContentPage
    {
        private SQLiteConnection SQLiteConnection;
        public RegistrationPage()
        {
            InitializeComponent();
            SQLiteConnection = DependencyService.Get<ISQLiteConnectionHelper>().GetConnection();
            SQLiteConnection.CreateTable<Member>();
        }

        private void SignUp_Button_Clicked(object sender, EventArgs e)
        {
            Member Member = new Member();
            Member.Name = Name.Text;
            Member.Email = Email.Text;
            Member.DOB = DOB.Date;
            Member.MobileNo = Convert.ToInt64(MobileNo.Text);
            Member.Password = Password.Text;
            int Count = SQLiteConnection.Insert(Member);
            if (Count > 0)
            {
                DisplayAlert("Registration Status", "Registered Successfully", "Ok");
            }
            else
            {
                DisplayAlert("Registration Status", "Not Saved....", "Cancel");
            }



        }
    }
}