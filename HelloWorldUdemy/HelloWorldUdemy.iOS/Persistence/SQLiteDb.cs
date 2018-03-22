using System;
using HelloWorldUdemy.Persistence;
using SQLite;
using System.IO;
using Xamarin.Forms;
using HelloWorldUdemy.iOS.Persistence;

[assembly: Dependency(typeof(SQLiteDb))]

namespace HelloWorldUdemy.iOS.Persistence
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}
