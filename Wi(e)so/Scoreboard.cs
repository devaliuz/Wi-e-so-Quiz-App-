using System.Data.SQLite;

namespace Wi_e_so
{
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
            LoadList();
        }
        private void LoadList()
        {
            SCORELIST.View = View.Details;
            try
            {
                int index = 0;

                using (SQLiteConnection connection = new SQLiteConnection("Data Source = C:\\Users\\Public\\Wieso\\Questions.sqlite3"))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Score", connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string[] row = { reader["Name"].ToString(), reader["Catalog"].ToString(), reader["Date"].ToString(), reader["Score"].ToString() };
                                var listViewItem = new ListViewItem(row);
                                SCORELIST.Items.Add(listViewItem);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_CLOSE_SCOREBOARD_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_DEL_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source = C:\\Users\\Public\\Wieso\\Questions.sqlite3"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand($"DROP TABLE Score", connection))
                {
                    command.ExecuteNonQuery();
                }
                using (SQLiteCommand command = new SQLiteCommand($"CREATE TABLE Score('Name' TEXT NOT NULL,'Catalog' TEXT NOT NULL, 'Score' INTEGER NOT NULL, 'Date' TEXT NOT NULL)", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            Close();
        }
    }
}
