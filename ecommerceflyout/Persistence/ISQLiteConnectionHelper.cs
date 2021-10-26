using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ecommerceflyout.Persistence
{
    public interface ISQLiteConnectionHelper
    {
        SQLiteConnection GetConnection();
    }
}
