﻿using System.Data.SQLite;

namespace Wi_e_so
{
    class DataBase
    {
        public DataBase()
        {
            if (!File.Exists("C:\\Users\\Public\\Wieso\\Questions.sqlite3"))
            {
                SQLiteConnection.CreateFile("C:\\Users\\Public\\Wieso\\Questions.sqlite3");
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection("Data Source = C:\\Users\\Public\\Wieso\\Questions.sqlite3"))
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand("CREATE TABLE Overview('Catalog' TEXT NOT NULL)", connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        using (SQLiteCommand command = new SQLiteCommand($"CREATE TABLE Score('Name' TEXT NOT NULL,'Catalog' TEXT NOT NULL, 'Score' INTEGER NOT NULL, 'Date' TEXT NOT NULL)", connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                
        }

        public int count(string table)
        {
            int entries = 0;
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source = C:\\Users\\Public\\Wieso\\Questions.sqlite3"))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM "+table, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    entries++;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return entries;
        }

        public string[] Load(string table, string column)
        {
            int entries = count(table);
            string[] arraytoreturn = new string[entries];
            try
            {
                int index = 0;

                using (SQLiteConnection connection = new SQLiteConnection("Data Source = C:\\Users\\Public\\Wieso\\Questions.sqlite3"))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM "+table , connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                arraytoreturn[index] = reader[column].ToString();
                                index++;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return arraytoreturn;
        }
    }
}