using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ecommerceflyout.Droid.Persistence;
using ecommerceflyout.Persistence;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

[assembly: Xamarin.Forms.Dependency(typeof(SQLiteConnectionHelper))]
namespace ecommerceflyout.Droid.Persistence
{
    public class SQLiteConnectionHelper : ISQLiteConnectionHelper
    {
        public SQLiteConnection GetConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "IntelDB.db3");
            return new SQLiteConnection(path);
        }
    }
}