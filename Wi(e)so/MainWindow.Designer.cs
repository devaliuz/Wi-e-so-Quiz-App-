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
            BTN_LOGIN = new Button();
            BTN_SCORE = new Button();
            CMB_CAT = new ComboBox();
            BTN_EDITKAT = new Button();
            LBL_QUESTION = new Label();
            RDB_A = new RadioButton();
            RDB_C = new RadioButton();
            RDB_B = new RadioButton();
            RDB_D = new RadioButton();
            LBL_USER = new Label();
            LBL_Progress = new Label();
            BTN_NEXT = new Button();
            NUM = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NUM).BeginInit();
            SuspendLayout();
            // 
            // BTN_LOGIN
            // 
            BTN_LOGIN.Location = new Point(12, 12);
            BTN_LOGIN.Name = "BTN_LOGIN";
            BTN_LOGIN.Size = new Size(75, 23);
            BTN_LOGIN.TabIndex = 0;
            BTN_LOGIN.Text = "Anmelden";
            BTN_LOGIN.UseVisualStyleBackColor = true;
            BTN_LOGIN.Click += BTN_LOGIN_Click;
            // 
            // BTN_SCORE
            // 
            BTN_SCORE.Location = new Point(12, 41);
            BTN_SCORE.Name = "BTN_SCORE";
            BTN_SCORE.Size = new Size(75, 23);
            BTN_SCORE.TabIndex = 1;
            BTN_SCORE.Text = "Ergebnisse";
            BTN_SCORE.UseVisualStyleBackColor = true;
            BTN_SCORE.Click += BTN_SCORE_Click;
            // 
            // CMB_CAT
            // 
            CMB_CAT.FormattingEnabled = true;
            CMB_CAT.Location = new Point(778, 13);
            CMB_CAT.Name = "CMB_CAT";
            CMB_CAT.Size = new Size(194, 23);
            CMB_CAT.TabIndex = 2;
            CMB_CAT.SelectedIndexChanged += CMB_CAT_SelectedIndexChanged;
            CMB_CAT.Click += CMB_CAT_Click;
            // 
            // BTN_EDITKAT
            // 
            BTN_EDITKAT.Location = new Point(778, 51);
            BTN_EDITKAT.Name = "BTN_EDITKAT";
            BTN_EDITKAT.Size = new Size(194, 23);
            BTN_EDITKAT.TabIndex = 3;
            BTN_EDITKAT.Text = "Kataloge bearbeiten";
            BTN_EDITKAT.UseVisualStyleBackColor = true;
            BTN_EDITKAT.Click += BTN_EDITKAT_Click;
            // 
            // LBL_QUESTION
            // 
            LBL_QUESTION.AutoSize = true;
            LBL_QUESTION.BackColor = Color.Transparent;
            LBL_QUESTION.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_QUESTION.Location = new Point(251, 51);
            LBL_QUESTION.MaximumSize = new Size(500, 250);
            LBL_QUESTION.MinimumSize = new Size(500, 250);
            LBL_QUESTION.Name = "LBL_QUESTION";
            LBL_QUESTION.Size = new Size(500, 250);
            LBL_QUESTION.TabIndex = 4;
            LBL_QUESTION.Text = "Hier könnte ihre Frage stehen";
            LBL_QUESTION.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RDB_A
            // 
            RDB_A.AutoSize = true;
            RDB_A.BackColor = Color.Transparent;
            RDB_A.Location = new Point(126, 310);
            RDB_A.MaximumSize = new Size(200, 100);
            RDB_A.MinimumSize = new Size(200, 100);
            RDB_A.Name = "RDB_A";
            RDB_A.Size = new Size(200, 100);
            RDB_A.TabIndex = 5;
            RDB_A.TabStop = true;
            RDB_A.Text = "A";
            RDB_A.UseVisualStyleBackColor = false;
            // 
            // RDB_C
            // 
            RDB_C.AutoSize = true;
            RDB_C.BackColor = Color.Transparent;
            RDB_C.Location = new Point(126, 416);
            RDB_C.MaximumSize = new Size(200, 100);
            RDB_C.MinimumSize = new Size(200, 100);
            RDB_C.Name = "RDB_C";
            RDB_C.Size = new Size(200, 100);
            RDB_C.TabIndex = 6;
            RDB_C.TabStop = true;
            RDB_C.Text = "C";
            RDB_C.UseVisualStyleBackColor = false;
            // 
            // RDB_B
            // 
            RDB_B.AutoSize = true;
            RDB_B.BackColor = Color.Transparent;
            RDB_B.Location = new Point(632, 310);
            RDB_B.MaximumSize = new Size(200, 100);
            RDB_B.MinimumSize = new Size(200, 100);
            RDB_B.Name = "RDB_B";
            RDB_B.Size = new Size(200, 100);
            RDB_B.TabIndex = 7;
            RDB_B.TabStop = true;
            RDB_B.Text = "B";
            RDB_B.UseVisualStyleBackColor = false;
            // 
            // RDB_D
            // 
            RDB_D.AutoSize = true;
            RDB_D.BackColor = Color.Transparent;
            RDB_D.Location = new Point(632, 416);
            RDB_D.MaximumSize = new Size(200, 100);
            RDB_D.MinimumSize = new Size(200, 100);
            RDB_D.Name = "RDB_D";
            RDB_D.Size = new Size(200, 100);
            RDB_D.TabIndex = 8;
            RDB_D.TabStop = true;
            RDB_D.Text = "D";
            RDB_D.UseVisualStyleBackColor = false;
            // 
            // LBL_USER
            // 
            LBL_USER.AutoSize = true;
            LBL_USER.BackColor = Color.Transparent;
            LBL_USER.Location = new Point(93, 16);
            LBL_USER.Name = "LBL_USER";
            LBL_USER.Size = new Size(30, 15);
            LBL_USER.TabIndex = 9;
            LBL_USER.Text = "User";
            // 
            // LBL_Progress
            // 
            LBL_Progress.AutoSize = true;
            LBL_Progress.BackColor = Color.Transparent;
            LBL_Progress.Location = new Point(778, 104);
            LBL_Progress.Name = "LBL_Progress";
            LBL_Progress.Size = new Size(30, 15);
            LBL_Progress.TabIndex = 10;
            LBL_Progress.Text = "x / y";
            // 
            // BTN_NEXT
            // 
            BTN_NEXT.BackColor = Color.LightGreen;
            BTN_NEXT.Location = new Point(863, 493);
            BTN_NEXT.Name = "BTN_NEXT";
            BTN_NEXT.Size = new Size(109, 45);
            BTN_NEXT.TabIndex = 11;
            BTN_NEXT.Text = "Weiter";
            BTN_NEXT.UseVisualStyleBackColor = false;
            BTN_NEXT.Click += BTN_NEXT_Click;
            // 
            // NUM
            // 
            NUM.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NUM.Location = new Point(460, 339);
            NUM.Name = "NUM";
            NUM.Size = new Size(88, 35);
            NUM.TabIndex = 12;
            NUM.Visible = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Back;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 561);
            Controls.Add(NUM);
            Controls.Add(BTN_NEXT);
            Controls.Add(LBL_Progress);
            Controls.Add(LBL_USER);
            Controls.Add(RDB_D);
            Controls.Add(RDB_B);
            Controls.Add(RDB_C);
            Controls.Add(RDB_A);
            Controls.Add(LBL_QUESTION);
            Controls.Add(BTN_EDITKAT);
            Controls.Add(CMB_CAT);
            Controls.Add(BTN_SCORE);
            Controls.Add(BTN_LOGIN);
            DoubleBuffered = true;
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(1000, 600);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wi(e)so";
            ((System.ComponentModel.ISupportInitialize)NUM).EndInit();
            ResumeLayout(false);
            PerformLayout();
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