using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;

namespace FysioterapiApp.Database
{
    public interface ISQLiteDB
    {
        SQLiteAsyncConnection GetConnection();
    }
}
