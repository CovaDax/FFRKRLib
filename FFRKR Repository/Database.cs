using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace FFRKR.DAL {
    class DB {
        protected MySqlConnection conn;
        protected string server;
        protected string database;
        protected string uid;
        protected string password;

        public DB() {
            Initialize();
        }

        private void Initialize() {
            server = "localhost";
            database = "ffrk";
            uid = "root";
            password = "password";
            string connectionString = String.Format("SERVER={0};DATABASE={1};UID={2};PASSWORD={3};", server, database, uid, password);
            conn = new MySqlConnection(connectionString);
        }

        protected bool OpenConnection() {
            try {
                conn.Open();
                return true;
            } catch (MySqlException ex) {
                switch (ex.Number) {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact Administrator");
                        Console.WriteLine("Cannot connect to server. Contact Administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        Console.WriteLine("Invalid username / password, please try again");
                        break;
                    default:
                        Console.WriteLine(String.Format(ex.Message));
                        break;
                }
                return false;
            }
        }

        protected bool CloseConnection() {
            try {
                conn.Close();
                return true;
            } catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Insert(string sql) {
            if (this.OpenConnection()) {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            this.CloseConnection();
        }


        protected string Select(string columns, string table, string whereColumns, string whereValues) {
            if (this.OpenConnection()) {
                string sql = String.Format("SELECT `{0}` FROM `{1}` WHERE `{2}` = '{3}';", columns, table, whereColumns, whereValues);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                string value;
                try {
                    value = cmd.ExecuteScalar().ToString();
                } catch (NullReferenceException e) {
                    value = String.Empty;
                }
                this.CloseConnection();
                return value;
            }
            this.CloseConnection();
            return "";
        }

        protected string Sanitize(string value) {
            return Regex.Replace(value, @" ?&^$#@!()+-,:;<>’\'-_*`", String.Empty);
        }

    }
}
