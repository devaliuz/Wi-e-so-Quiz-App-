using System.Data.SQLite;

namespace Wi_e_so
{
    public partial class QuestEdit : Form
    {
        public QuestEdit()
        {
            InitializeComponent();
            LoadDropdown();
            BTN_DEL_TAB.Enabled = false;
        }
        DataBase database = new DataBase();

        void LoadDropdown()
        {
            CMB_CAT_TODEL.Text = "Fragenkatalog wählen";
            try
            {
                CMB_CAT_TODEL.Items.Clear();
                string[] strArray = database.Load("Overview", "Catalog");
                for (int i = 0; i < strArray.Length; i++)
                {
                    CMB_CAT_TODEL.Items.Add(strArray[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_ADD_CAT_Click(object sender, EventArgs e)
        {
            if (TB_TABLENAME.Text.Length == 0) MessageBox.Show("Bitte einen Namen für die Tabelle angeben!");
            else
            {
                try
                {
                    string table = TB_TABLENAME.Text.ToString();
                    using (SQLiteConnection connection = new SQLiteConnection("Data Source = "+ database.getPath()))
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand($"CREATE TABLE " + table + " " +
                            "('Question' TEXT NOT NULL," +
                            "'Questiontype' TEXT NOT NULL," +
                            "'Correct' TEXT NOT NULL, " +
                            "'Answer_A' TEXT ," +
                            "'Answer_B' TEXT ," +
                            "'Answer_C' TEXT ," +
                            "'Answer_D' TEXT )", connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        int rows = DG_NEW.RowCount;
                        for (int i = 0; i < rows - 1; i++)
                        {
                            using (SQLiteCommand command1 = new SQLiteCommand("INSERT INTO " + table + "(Question, Questiontype, Correct, Answer_A, Answer_B, Answer_C, Answer_D)" +
                                "VALUES(@Question, @Questiontype, @Correct, @Answer_A, @Answer_B, @Answer_C, @Answer_D)", connection))
                            {
                                command1.Parameters.AddWithValue("@Question", DG_NEW["Column1", i].Value.ToString());
                                command1.Parameters.AddWithValue("@Questiontype", DG_NEW["Column2", i].Value.ToString());
                                command1.Parameters.AddWithValue("@Correct", DG_NEW["Column3", i].Value.ToString());
                                command1.Parameters.AddWithValue("@Answer_A", DG_NEW["Column4", i].Value.ToString());
                                command1.Parameters.AddWithValue("@Answer_B", DG_NEW["Column5", i].Value.ToString());
                                command1.Parameters.AddWithValue("@Answer_C", DG_NEW["Column6", i].Value.ToString());
                                command1.Parameters.AddWithValue("@Answer_D", DG_NEW["Column7", i].Value.ToString());
                                command1.ExecuteNonQuery();
                            }
                        }
                        using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Overview(Catalog) VALUES(@Catalog)", connection))
                        {
                            command.Parameters.AddWithValue("@Catalog", table);
                            command.ExecuteNonQuery();
                        }
                        DG_NEW.Rows.Clear();
                        TB_TABLENAME.Clear();
                        LoadDropdown();
                        MessageBox.Show("Der Fragenkatalog " + table + " wurde der Datenbank hinzugefügt.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BTN_DEL_TAB_Click(object sender, EventArgs e)
        {
            string todel = "'"+CMB_CAT_TODEL.SelectedItem.ToString()+"'";
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source = "+ database.getPath()))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand("DROP TABLE "+todel+";", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Overview WHERE Catalog ="+todel+";", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                LoadDropdown();
                MessageBox.Show("Der Fragenkatalog " + todel + " wurde aus der Datenbank entfernt.");
                BTN_DEL_TAB.Enabled = false;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CMB_CAT_TODEL_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTN_DEL_TAB.Enabled = true;
        }
    }
}
