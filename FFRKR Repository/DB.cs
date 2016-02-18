using System;
using System.Data.SQLite;

namespace FFRKR.Repository {
    public class DB {
        protected string _server;
        protected string _database;
        protected string _uid;
        protected string _password;

        protected SQLiteConnection _conn;

        protected DB() {
            string connectionString = "Data Source=FFRKR.sqlite;Version=3;";
            _conn = new SQLiteConnection(connectionString);
        }

        protected bool OpenConnection() {
            try {
                _conn.Open();
                return true;
            } catch (SQLiteException ex) {
                // Log Message
                return false;
            }
        }

        protected bool CloseConnection() {
            try {
                _conn.Close();
                return true;
            } catch (SQLiteException ex) {
                // Log Message
                return false;
            }
        }
    }
}
