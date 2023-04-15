using System.Data.SQLite;

namespace Wi_e_so
{
    public partial class MainWindow : Form
    {
        DataBase database = new DataBase();
        public string name = "";
        private bool signedin = false;
        public int frageMax = 0;
        public string cat = "";
        public int question = 1;
        public string questionType = "";
        public string correct = "";
        public int score = 0;
        public MainWindow()
        {
            InitializeComponent();
            LBL_Progress.Text = "";
            BTN_NEXT.Visible = false;
            LoadDropdown();
            LoginCheck();
        }

        private void BTN_LOGIN_Click(object sender, EventArgs e)
        {
            if (signedin == false)
            {
                Login login = new Login(this);
                login.ShowDialog();
                if (name != "")
                {
                    signedin = true;
                    LoginCheck();
                }
            }
            else
            {
                signedin = false;
                LoginCheck();
            }
        }

        private void LoginCheck()
        {
            if (signedin == false)
            {
                name = "";
                LBL_USER.Text = name;
                BTN_LOGIN.Text = "Anmelden";
                BTN_LOGIN.BackColor = Color.LightGreen;
                LBL_QUESTION.Visible = false;
                LBL_Progress.Text = "";
                RDB_A.Visible = false;
                RDB_B.Visible = false;
                RDB_C.Visible = false;
                RDB_D.Visible = false;
                BTN_NEXT.Visible = false;
                BTN_EDITKAT.Visible = false;
                BTN_SCORE.Visible = false;
                CMB_CAT.Enabled = false;
                question = 1;
                score = 0;
            }
            else
            {
                LBL_USER.Text = name;
                BTN_LOGIN.Text = "Abmelden";
                BTN_LOGIN.BackColor = Color.IndianRed;
                CMB_CAT.Enabled = true;
                if (name == "Bötzer")
                {
                    BTN_EDITKAT.Visible = true;
                    BTN_SCORE.Visible = true;
                }
            }
        }

        private void BTN_SCORE_Click(object sender, EventArgs e)
        {
            Scoreboard sb = new Scoreboard();
            sb.Show();
        }

        private void BTN_EDITKAT_Click(object sender, EventArgs e)
        {
            QuestEdit qe = new QuestEdit();
            qe.Show();
        }


        void LoadDropdown()
        {
            CMB_CAT.Text = "Fragenkatalog wählen";
            try
            {
                CMB_CAT.Items.Clear();
                string[] strArray = database.Load("Overview","Catalog");
                for (int i = 0; i < strArray.Length; i++)
                {
                    CMB_CAT.Items.Add(strArray[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CMB_CAT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (signedin == true)
            {
                LBL_QUESTION.Visible = true;
                RDB_A.Visible = true;
                RDB_B.Visible = true;
                RDB_C.Visible = true;
                RDB_D.Visible = true;
                CMB_CAT.Enabled = false;
                BTN_NEXT.Visible = true;
                BTN_EDITKAT.Visible = false;
            }
            cat = CMB_CAT.SelectedItem.ToString();
            LoadQuestion();

        }

        private void CMB_CAT_Click(object sender, EventArgs e)
        {
            LoadDropdown();
        }


        public void LoadQuestion()
        {
            try
            {
                frageMax = database.count(cat);                                                             //Saves counted rows into a Variable                
            }
            catch
            {
                MessageBox.Show("Fehler beim lesen.");
            }

            try
            {
                using (SQLiteConnection c = new SQLiteConnection("Data Source = Questions.sqlite3"))
                {
                    c.Open();
                    string query = "SELECT * FROM " + cat + " WHERE _rowid_ = " + question;
                    using (SQLiteCommand rowdata = new SQLiteCommand(query, c))
                    {
                        using (SQLiteDataReader rowreader = rowdata.ExecuteReader())
                        {
                            rowreader.Read();


                            LBL_Progress.Text = "Frage " + question + "/" + frageMax;
                            LBL_QUESTION.Text = rowreader["Question"].ToString();
                            questionType = rowreader["Questiontype"].ToString();

                            if (questionType == "MC")
                            {
                                RDB_A.Visible = true;
                                RDB_A.Checked = true;
                                RDB_B.Visible = true;
                                RDB_C.Visible = true;
                                RDB_D.Visible = true;
                                NUM.Visible = false;
                                //TB_Answer.Visible = false;
                                RDB_A.Text = rowreader["Answer_A"].ToString();                                     //Displays a possible answer
                                RDB_B.Text = rowreader["Answer_B"].ToString();                                     //**
                                RDB_C.Text = rowreader["Answer_C"].ToString();                                     //**
                                RDB_D.Text = rowreader["Answer_D"].ToString();                                     //**
                                correct = rowreader["Correct"].ToString();                            //saves right answer into a variable
                            }
                            else if (questionType == "Num")
                            {
                                RDB_A.Visible = false;
                                RDB_B.Visible = false;
                                RDB_C.Visible = false;
                                RDB_D.Visible = false;
                                NUM.Visible = true;
                                //TB_Answer.Visible = false;
                                correct = rowreader["Correct"].ToString();                            //saves right answer into a variable

                            }/*
                            else if (QuestionType == "Text")
                            {
                                Antwort_A.Visible = false;
                                Antwort_B.Visible = false;
                                Antwort_C.Visible = false;
                                Antwort_D.Visible = false;
                                MATH_NUM.Visible = false;
                                TB_Answer.Visible = true;
                                Richtige_Antwort = rowreader["Richtige_Antwort"].ToString();                            //saves right answer into a variable
                            }
                            string picpath = rowreader["Bild"].ToString();                                              //gets picturname from DB
                            BildBox.Image = Image.FromFile(@"Pics\" + picpath); */                                        //picture NEEDS to be in "Pics" folder atm
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Unerwarteter Fehler aufgetreten!");                                     //if anything goes wrong with this process....
            }
        }

        private void BTN_NEXT_Click(object sender, EventArgs e)
        {
            if (RDB_A.Checked == true)
            {
                if (RDB_A.Text == correct)
                {
                    score++;
                }
            }
            if (RDB_B.Checked == true)
            {
                if (RDB_B.Text == correct)
                {
                    score++;
                }
            }
            if (RDB_C.Checked == true)
            {
                if (RDB_C.Text == correct)
                {
                    score++;
                }
            }
            if (RDB_D.Checked == true)
            {
                if (RDB_D.Text == correct)
                {
                    score++;
                }
            }

            if (NUM.Value.ToString() == correct)
            {
                score++;
            }

            if (question == frageMax)
            {
                LBL_QUESTION.Visible = false;
                RDB_A.Visible = false;
                RDB_B.Visible = false;
                RDB_C.Visible = false;
                RDB_D.Visible = false;
                LBL_Progress.Text = "Du hast " + score + " von " + frageMax + " Punkte erreicht!";

                using (SQLiteConnection c = new SQLiteConnection("Data Source = Questions.sqlite3"))
                {
                    c.Open();
                    string query = "INSERT INTO Score('Name', 'Score', 'Catalog','Date') VALUES(@Name,@Score,@Catalog, @Date)";
                    SQLiteCommand command1 = new SQLiteCommand(query, c);
                    command1.Parameters.AddWithValue("@Name", name);
                    command1.Parameters.AddWithValue("@Score", score);
                    command1.Parameters.AddWithValue("@Catalog", cat);
                    command1.Parameters.AddWithValue("Date", DateTime.Now.ToString());
                    command1.ExecuteNonQuery();
                }
                question = 1;
                score = 0;
                BTN_NEXT.Visible = false;
                CMB_CAT.Enabled = true;
                NUM.Visible =false;

            }
            else
            {
                question++;
                RDB_A.Checked = true;
                NUM.Value = 0;
                LoadQuestion();
            }
        }
    }
}