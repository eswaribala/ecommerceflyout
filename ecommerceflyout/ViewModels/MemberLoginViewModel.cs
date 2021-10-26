using ecommerceflyout.Models;
using ecommerceflyout.Persistence;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ecommerceflyout.ViewModels
{
    public class MemberLoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Action ValidLoginPrompt;
        public Action InValidLoginPrompt;

        private SQLiteConnection _SQLiteConnection;
        private ICommand SubmitCommand { get; set; }

        private string _Email;
        private string _Password;

        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public MemberLoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }

        private void OnSubmit(object obj)
        {
            _SQLiteConnection= DependencyService.Get<ISQLiteConnectionHelper>().GetConnection();

            _SQLiteConnection.CreateTable<Member>();
            if (!LoginValidation(Email, Password))
            {
                InValidLoginPrompt();
            }
            else
                ValidLoginPrompt();

        }


        public Boolean LoginValidation(string Email,string Password)
        {

            var data = _SQLiteConnection.Table<Member>();
            var d1 = data.Where(x => x.Email == Email && x.Password ==Password).FirstOrDefault();

            if (d1 != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
