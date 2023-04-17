namespace Wi_e_so
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.BTN_LOGIN = new System.Windows.Forms.Button();
            this.BTN_SCORE = new System.Windows.Forms.Button();
            this.CMB_CAT = new System.Windows.Forms.ComboBox();
            this.BTN_EDITKAT = new System.Windows.Forms.Button();
            this.LBL_QUESTION = new System.Windows.Forms.Label();
            this.RDB_A = new System.Windows.Forms.RadioButton();
            this.RDB_C = new System.Windows.Forms.RadioButton();
            this.RDB_B = new System.Windows.Forms.RadioButton();
            this.RDB_D = new System.Windows.Forms.RadioButton();
            this.LBL_USER = new System.Windows.Forms.Label();
            this.LBL_Progress = new System.Windows.Forms.Label();
            this.BTN_NEXT = new System.Windows.Forms.Button();
            this.NUM = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUM)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_LOGIN
            // 
            this.BTN_LOGIN.Location = new System.Drawing.Point(12, 12);
            this.BTN_LOGIN.Name = "BTN_LOGIN";
            this.BTN_LOGIN.Size = new System.Drawing.Size(75, 23);
            this.BTN_LOGIN.TabIndex = 0;
            this.BTN_LOGIN.Text = "Anmelden";
            this.BTN_LOGIN.UseVisualStyleBackColor = true;
            this.BTN_LOGIN.Click += new System.EventHandler(this.BTN_LOGIN_Click);
            // 
            // BTN_SCORE
            // 
            this.BTN_SCORE.Location = new System.Drawing.Point(12, 41);
            this.BTN_SCORE.Name = "BTN_SCORE";
            this.BTN_SCORE.Size = new System.Drawing.Size(75, 23);
            this.BTN_SCORE.TabIndex = 1;
            this.BTN_SCORE.Text = "Ergebnisse";
            this.BTN_SCORE.UseVisualStyleBackColor = true;
            this.BTN_SCORE.Click += new System.EventHandler(this.BTN_SCORE_Click);
            // 
            // CMB_CAT
            // 
            this.CMB_CAT.FormattingEnabled = true;
            this.CMB_CAT.Location = new System.Drawing.Point(778, 13);
            this.CMB_CAT.Name = "CMB_CAT";
            this.CMB_CAT.Size = new System.Drawing.Size(194, 23);
            this.CMB_CAT.TabIndex = 2;
            this.CMB_CAT.SelectedIndexChanged += new System.EventHandler(this.CMB_CAT_SelectedIndexChanged);
            this.CMB_CAT.Click += new System.EventHandler(this.CMB_CAT_Click);
            // 
            // BTN_EDITKAT
            // 
            this.BTN_EDITKAT.Location = new System.Drawing.Point(778, 51);
            this.BTN_EDITKAT.Name = "BTN_EDITKAT";
            this.BTN_EDITKAT.Size = new System.Drawing.Size(194, 23);
            this.BTN_EDITKAT.TabIndex = 3;
            this.BTN_EDITKAT.Text = "Kataloge bearbeiten";
            this.BTN_EDITKAT.UseVisualStyleBackColor = true;
            this.BTN_EDITKAT.Click += new System.EventHandler(this.BTN_EDITKAT_Click);
            // 
            // LBL_QUESTION
            // 
            this.LBL_QUESTION.AutoSize = true;
            this.LBL_QUESTION.BackColor = System.Drawing.Color.Transparent;
            this.LBL_QUESTION.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_QUESTION.Location = new System.Drawing.Point(251, 51);
            this.LBL_QUESTION.MaximumSize = new System.Drawing.Size(500, 250);
            this.LBL_QUESTION.MinimumSize = new System.Drawing.Size(500, 250);
            this.LBL_QUESTION.Name = "LBL_QUESTION";
            this.LBL_QUESTION.Size = new System.Drawing.Size(500, 250);
            this.LBL_QUESTION.TabIndex = 4;
            this.LBL_QUESTION.Text = "Hier könnte ihre Frage stehen";
            this.LBL_QUESTION.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RDB_A
            // 
            this.RDB_A.AutoSize = true;
            this.RDB_A.BackColor = System.Drawing.Color.Transparent;
            this.RDB_A.Location = new System.Drawing.Point(126, 310);
            this.RDB_A.MaximumSize = new System.Drawing.Size(200, 100);
            this.RDB_A.MinimumSize = new System.Drawing.Size(200, 100);
            this.RDB_A.Name = "RDB_A";
            this.RDB_A.Size = new System.Drawing.Size(200, 100);
            this.RDB_A.TabIndex = 5;
            this.RDB_A.TabStop = true;
            this.RDB_A.Text = "A";
            this.RDB_A.UseVisualStyleBackColor = false;
            // 
            // RDB_C
            // 
            this.RDB_C.AutoSize = true;
            this.RDB_C.BackColor = System.Drawing.Color.Transparent;
            this.RDB_C.Location = new System.Drawing.Point(126, 416);
            this.RDB_C.MaximumSize = new System.Drawing.Size(200, 100);
            this.RDB_C.MinimumSize = new System.Drawing.Size(200, 100);
            this.RDB_C.Name = "RDB_C";
            this.RDB_C.Size = new System.Drawing.Size(200, 100);
            this.RDB_C.TabIndex = 6;
            this.RDB_C.TabStop = true;
            this.RDB_C.Text = "C";
            this.RDB_C.UseVisualStyleBackColor = false;
            // 
            // RDB_B
            // 
            this.RDB_B.AutoSize = true;
            this.RDB_B.BackColor = System.Drawing.Color.Transparent;
            this.RDB_B.Location = new System.Drawing.Point(632, 310);
            this.RDB_B.MaximumSize = new System.Drawing.Size(200, 100);
            this.RDB_B.MinimumSize = new System.Drawing.Size(200, 100);
            this.RDB_B.Name = "RDB_B";
            this.RDB_B.Size = new System.Drawing.Size(200, 100);
            this.RDB_B.TabIndex = 7;
            this.RDB_B.TabStop = true;
            this.RDB_B.Text = "B";
            this.RDB_B.UseVisualStyleBackColor = false;
            // 
            // RDB_D
            // 
            this.RDB_D.AutoSize = true;
            this.RDB_D.BackColor = System.Drawing.Color.Transparent;
            this.RDB_D.Location = new System.Drawing.Point(632, 416);
            this.RDB_D.MaximumSize = new System.Drawing.Size(200, 100);
            this.RDB_D.MinimumSize = new System.Drawing.Size(200, 100);
            this.RDB_D.Name = "RDB_D";
            this.RDB_D.Size = new System.Drawing.Size(200, 100);
            this.RDB_D.TabIndex = 8;
            this.RDB_D.TabStop = true;
            this.RDB_D.Text = "D";
            this.RDB_D.UseVisualStyleBackColor = false;
            // 
            // LBL_USER
            // 
            this.LBL_USER.AutoSize = true;
            this.LBL_USER.BackColor = System.Drawing.Color.Transparent;
            this.LBL_USER.Location = new System.Drawing.Point(93, 16);
            this.LBL_USER.Name = "LBL_USER";
            this.LBL_USER.Size = new System.Drawing.Size(30, 15);
            this.LBL_USER.TabIndex = 9;
            this.LBL_USER.Text = "User";
            // 
            // LBL_Progress
            // 
            this.LBL_Progress.AutoSize = true;
            this.LBL_Progress.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Progress.Location = new System.Drawing.Point(778, 104);
            this.LBL_Progress.Name = "LBL_Progress";
            this.LBL_Progress.Size = new System.Drawing.Size(30, 15);
            this.LBL_Progress.TabIndex = 10;
            this.LBL_Progress.Text = "x / y";
            // 
            // BTN_NEXT
            // 
            this.BTN_NEXT.BackColor = System.Drawing.Color.LightGreen;
            this.BTN_NEXT.Location = new System.Drawing.Point(863, 493);
            this.BTN_NEXT.Name = "BTN_NEXT";
            this.BTN_NEXT.Size = new System.Drawing.Size(109, 45);
            this.BTN_NEXT.TabIndex = 11;
            this.BTN_NEXT.Text = "Weiter";
            this.BTN_NEXT.UseVisualStyleBackColor = false;
            this.BTN_NEXT.Click += new System.EventHandler(this.BTN_NEXT_Click);
            // 
            // NUM
            // 
            this.NUM.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NUM.Location = new System.Drawing.Point(460, 339);
            this.NUM.Name = "NUM";
            this.NUM.Size = new System.Drawing.Size(88, 35);
            this.NUM.TabIndex = 12;
            this.NUM.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wi_e_so.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.NUM);
            this.Controls.Add(this.BTN_NEXT);
            this.Controls.Add(this.LBL_Progress);
            this.Controls.Add(this.LBL_USER);
            this.Controls.Add(this.RDB_D);
            this.Controls.Add(this.RDB_B);
            this.Controls.Add(this.RDB_C);
            this.Controls.Add(this.RDB_A);
            this.Controls.Add(this.LBL_QUESTION);
            this.Controls.Add(this.BTN_EDITKAT);
            this.Controls.Add(this.CMB_CAT);
            this.Controls.Add(this.BTN_SCORE);
            this.Controls.Add(this.BTN_LOGIN);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wi(e)so";
            ((System.ComponentModel.ISupportInitialize)(this.NUM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTN_LOGIN;
        private Button BTN_SCORE;
        private ComboBox CMB_CAT;
        private Button BTN_EDITKAT;
        private Label LBL_QUESTION;
        private RadioButton RDB_A;
        private RadioButton RDB_C;
        private RadioButton RDB_B;
        private RadioButton RDB_D;
        private Label LBL_USER;
        private Label LBL_Progress;
        private Button BTN_NEXT;
        private NumericUpDown NUM;
    }
}