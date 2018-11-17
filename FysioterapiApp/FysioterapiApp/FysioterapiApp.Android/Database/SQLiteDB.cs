using System;
using System.IO;
using FysioterapiApp.Droid.Database;
using SQLite;
using Xamarin.Forms;


[assembly: Dependency(typeof(SQLiteDB))]
namespace FysioterapiApp.Droid.Database
{
    public class SQLiteDB : FysioterapiApp.Database.ISQLiteDB
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db4");

            return new SQLiteAsyncConnection(path);
        }
    }
}