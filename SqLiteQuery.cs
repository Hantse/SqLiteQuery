using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;

namespace SqLiteQuery
{
    public class SqLiteQuery
    {
        protected SQLiteConnection _SqLiteConnection;
        protected SQLiteCommand _SqLiteCommand;

        public SqLiteQuery(string Source)
        {
            _SqLiteConnection = new SQLiteConnection("Data Source=" + Source + ";Version=3;New=False;Compress=True;");
            _SqLiteCommand = _SqLiteConnection.CreateCommand();
            _SqLiteConnection.Open();
        }

        public SqLiteQuery(string Source, string Version)
        {
            _SqLiteConnection = new SQLiteConnection("Data Source=" + Source + ";Version=" + Version + ";New=False;Compress=True;");
            _SqLiteCommand = _SqLiteConnection.CreateCommand();
            _SqLiteConnection.Open();
        }

        public SqLiteQuery(string Source, string Version, Boolean New)
        {
            _SqLiteConnection = new SQLiteConnection("Data Source=" + Source + ";Version=" + Version + ";New=" + New + ";Compress=True;");
            _SqLiteCommand = _SqLiteConnection.CreateCommand();
            _SqLiteConnection.Open();
        }

        public SqLiteQuery(string Source, string Version, Boolean New, Boolean Compress)
        {
            _SqLiteConnection = new SQLiteConnection("Data Source=" + Source + ";Version=" + Version + ";New=" + New + ";Compress=" + Compress + ";");
            _SqLiteCommand = _SqLiteConnection.CreateCommand();
            _SqLiteConnection.Open();
        }

        public void OpenConnection(){
            _SqLiteConnection.Open();
        }

        public void CloseConnection()
        {
            _SqLiteConnection.Close();
        }

        ~SqLiteQuery()
        {
            _SqLiteConnection.Close();
        }
    }
}
