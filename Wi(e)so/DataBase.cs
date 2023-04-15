using System.Data.SQLite;

namespace Wi_e_so
{
    class DataBase
    {
        public DataBase()
        {
            if (!File.Exists("./Questions.sqlite3"))
            {
                SQLiteConnection.CreateFile("Questions.sqlite3");
            }
        }

        public int count(string table)
        {
            int entries = 0;
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source = Questions.sqlite3"))
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

                using (SQLiteConnection connection = new SQLiteConnection("Data Source = Questions.sqlite3"))
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