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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scoreboard));
            this.SCORELIST = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_CLOSE_SCOREBOARD = new System.Windows.Forms.Button();
            this.BTN_DEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SCORELIST
            // 
            this.SCORELIST.BackColor = System.Drawing.SystemColors.Info;
            this.SCORELIST.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.SCORELIST.Location = new System.Drawing.Point(12, 12);
            this.SCORELIST.Name = "SCORELIST";
            this.SCORELIST.Size = new System.Drawing.Size(550, 300);
            this.SCORELIST.TabIndex = 0;
            this.SCORELIST.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Katalog";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Datum";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Punkte";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BTN_CLOSE_SCOREBOARD
            // 
            this.BTN_CLOSE_SCOREBOARD.Location = new System.Drawing.Point(461, 318);
            this.BTN_CLOSE_SCOREBOARD.Name = "BTN_CLOSE_SCOREBOARD";
            this.BTN_CLOSE_SCOREBOARD.Size = new System.Drawing.Size(101, 31);
            this.BTN_CLOSE_SCOREBOARD.TabIndex = 2;
            this.BTN_CLOSE_SCOREBOARD.Text = "Schließen";
            this.BTN_CLOSE_SCOREBOARD.UseVisualStyleBackColor = true;
            this.BTN_CLOSE_SCOREBOARD.Click += new System.EventHandler(this.BTN_CLOSE_SCOREBOARD_Click);
            // 
            // BTN_DEL
            // 
            this.BTN_DEL.Location = new System.Drawing.Point(12, 318);
            this.BTN_DEL.Name = "BTN_DEL";
            this.BTN_DEL.Size = new System.Drawing.Size(108, 31);
            this.BTN_DEL.TabIndex = 3;
            this.BTN_DEL.Text = "Einträge Löschen";
            this.BTN_DEL.UseVisualStyleBackColor = true;
            this.BTN_DEL.Click += new System.EventHandler(this.BTN_DEL_Click);
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wi_e_so.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.BTN_DEL);
            this.Controls.Add(this.BTN_CLOSE_SCOREBOARD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SCORELIST);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Scoreboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scoreboard";
            this.ResumeLayout(false);

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