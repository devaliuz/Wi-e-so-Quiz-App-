namespace Wi_e_so
{
    partial class Scoreboard
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
            SCORELIST = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button1 = new Button();
            BTN_CLOSE_SCOREBOARD = new Button();
            BTN_DEL = new Button();
            SuspendLayout();
            // 
            // SCORELIST
            // 
            SCORELIST.BackColor = SystemColors.Info;
            SCORELIST.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            SCORELIST.Location = new Point(12, 12);
            SCORELIST.Name = "SCORELIST";
            SCORELIST.Size = new Size(550, 300);
            SCORELIST.TabIndex = 0;
            SCORELIST.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Katalog";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Datum";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Punkte";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 120;
            // 
            // button1
            // 
            button1.Location = new Point(670, 370);
            button1.Name = "button1";
            button1.Size = new Size(118, 43);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // BTN_CLOSE_SCOREBOARD
            // 
            BTN_CLOSE_SCOREBOARD.Location = new Point(461, 318);
            BTN_CLOSE_SCOREBOARD.Name = "BTN_CLOSE_SCOREBOARD";
            BTN_CLOSE_SCOREBOARD.Size = new Size(101, 31);
            BTN_CLOSE_SCOREBOARD.TabIndex = 2;
            BTN_CLOSE_SCOREBOARD.Text = "Schließen";
            BTN_CLOSE_SCOREBOARD.UseVisualStyleBackColor = true;
            BTN_CLOSE_SCOREBOARD.Click += BTN_CLOSE_SCOREBOARD_Click;
            // 
            // BTN_DEL
            // 
            BTN_DEL.Location = new Point(12, 318);
            BTN_DEL.Name = "BTN_DEL";
            BTN_DEL.Size = new Size(108, 31);
            BTN_DEL.TabIndex = 3;
            BTN_DEL.Text = "Einträge Löschen";
            BTN_DEL.UseVisualStyleBackColor = true;
            BTN_DEL.Click += BTN_DEL_Click;
            // 
            // Scoreboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Back;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(584, 361);
            Controls.Add(BTN_DEL);
            Controls.Add(BTN_CLOSE_SCOREBOARD);
            Controls.Add(button1);
            Controls.Add(SCORELIST);
            DoubleBuffered = true;
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "Scoreboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scoreboard";
            ResumeLayout(false);
        }

        #endregion

        private ListView SCORELIST;
        private Button button1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button BTN_CLOSE_SCOREBOARD;
        private Button BTN_DEL;
    }
}