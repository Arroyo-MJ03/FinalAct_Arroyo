using System;
using System.Data.OleDb;
using System.IO;

namespace FinalAct_Arroyo
{
    public static class Database
    {
        public static readonly string DBPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\inventory.accdb");

        private static readonly string CONNECTION_STRING = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DBPath + ";Persist Security Info=False;";

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(CONNECTION_STRING);
        }
    }
}