namespace Wi_e_so
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TB_USER = new TextBox();
            TB_PW = new TextBox();
            BTN_LOG = new Button();
            SuspendLayout();
            // 
            // TB_USER
            // 
            TB_USER.Location = new Point(37, 40);
            TB_USER.Name = "TB_USER";
            TB_USER.PlaceholderText = "Benutzername";
            TB_USER.Size = new Size(317, 23);
            TB_USER.TabIndex = 0;
            TB_USER.TextAlign = HorizontalAlignment.Center;
            TB_USER.KeyUp += TB_USER_KeyUp;
            // 
            // TB_PW
            // 
            TB_PW.Location = new Point(37, 69);
            TB_PW.Name = "TB_PW";
            TB_PW.PasswordChar = '*';
            TB_PW.PlaceholderText = "Passwort";
            TB_PW.Size = new Size(317, 23);
            TB_PW.TabIndex = 1;
            TB_PW.TextAlign = HorizontalAlignment.Center;
            TB_PW.Visible = false;
            // 
            // BTN_LOG
            // 
            BTN_LOG.Location = new Point(37, 98);
            BTN_LOG.Name = "BTN_LOG";
            BTN_LOG.Size = new Size(317, 23);
            BTN_LOG.TabIndex = 2;
            BTN_LOG.Text = "Anmelden";
            BTN_LOG.UseVisualStyleBackColor = true;
            BTN_LOG.Click += BTN_LOG_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Back;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(384, 161);
            Controls.Add(BTN_LOG);
            Controls.Add(TB_PW);
            Controls.Add(TB_USER);
            DoubleBuffered = true;
            MaximumSize = new Size(400, 200);
            MinimumSize = new Size(400, 200);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_USER;
        private TextBox TB_PW;
        private Button BTN_LOG;
    }
}