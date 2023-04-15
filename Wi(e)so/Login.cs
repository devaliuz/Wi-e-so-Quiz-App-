using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wi_e_so
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private MainWindow mainwindow;
        public string name;

        public Login(MainWindow mainWindow) : this()
        {
            this.mainwindow = mainWindow;
        }

        private void TB_USER_KeyUp(object sender, KeyEventArgs e)
        {
            if (TB_USER.Text.ToString() == "Bötzer")
            {
                TB_PW.Visible = true;
            }
            else { TB_PW.Visible = false; }
        }

        private void BTN_LOG_Click(object sender, EventArgs e)
        {
            if (TB_USER.Text != "")
            {
                if (TB_USER.Text.ToString() == "Bötzer")
                {
                    if (CheckPw(TB_PW.Text.ToString()) == true)
                    {
                        mainwindow.name = TB_USER.Text;
                        name = TB_USER.Text;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Falsches Passwort für Bötzer");
                    }
                }
                else
                {
                    mainwindow.name = TB_USER.Text;
                    name = TB_USER.Text;
                    Close();
                }
            }
            else 
            {
                MessageBox.Show("Bitte Nutzernamen angeben!");
            }
        }

        private bool CheckPw(string pw)
        {

            return true;

            return false;
        }
    }
}
