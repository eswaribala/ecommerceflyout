using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ecommerceflyout.Persistence;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ecommerceflyout.Droid.Persistence
{
    public class SQLiteConnectionHelper : ISQLiteConnectionHelper
    {
        public SQLiteConnection GetConnection()
        {
           var FilePath= System.Environment.GetFolderPath(System.Environment.
               SpecialFolder.MyDocuments);

          String DBPath =  Path.Combine(FilePath, "IntelDB");
            return new SQLiteConnection(DBPath);
        }
    }
}