using System;
using SQLite;

namespace HelloWorldUdemy.Persistence
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
