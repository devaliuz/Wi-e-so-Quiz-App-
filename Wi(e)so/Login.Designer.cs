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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TB_USER = new System.Windows.Forms.TextBox();
            this.TB_PW = new System.Windows.Forms.TextBox();
            this.BTN_LOG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_USER
            // 
            this.TB_USER.Location = new System.Drawing.Point(37, 40);
            this.TB_USER.Name = "TB_USER";
            this.TB_USER.PlaceholderText = "Benutzername";
            this.TB_USER.Size = new System.Drawing.Size(317, 23);
            this.TB_USER.TabIndex = 0;
            this.TB_USER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_USER.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_USER_KeyUp);
            // 
            // TB_PW
            // 
            this.TB_PW.Location = new System.Drawing.Point(37, 69);
            this.TB_PW.Name = "TB_PW";
            this.TB_PW.PasswordChar = '*';
            this.TB_PW.PlaceholderText = "Passwort";
            this.TB_PW.Size = new System.Drawing.Size(317, 23);
            this.TB_PW.TabIndex = 1;
            this.TB_PW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_PW.Visible = false;
            // 
            // BTN_LOG
            // 
            this.BTN_LOG.Location = new System.Drawing.Point(37, 98);
            this.BTN_LOG.Name = "BTN_LOG";
            this.BTN_LOG.Size = new System.Drawing.Size(317, 23);
            this.BTN_LOG.TabIndex = 2;
            this.BTN_LOG.Text = "Anmelden";
            this.BTN_LOG.UseVisualStyleBackColor = true;
            this.BTN_LOG.Click += new System.EventHandler(this.BTN_LOG_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wi_e_so.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.BTN_LOG);
            this.Controls.Add(this.TB_PW);
            this.Controls.Add(this.TB_USER);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TB_USER;
        private TextBox TB_PW;
        private Button BTN_LOG;
    }
}