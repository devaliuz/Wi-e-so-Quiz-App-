namespace Wi_e_so
{
    partial class QuestEdit
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
            DG_NEW = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            TB_TABLENAME = new TextBox();
            CMB_CAT_TODEL = new ComboBox();
            BTN_ADD_CAT = new Button();
            BTN_DEL_TAB = new Button();
            ((System.ComponentModel.ISupportInitialize)DG_NEW).BeginInit();
            SuspendLayout();
            // 
            // DG_NEW
            // 
            DG_NEW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_NEW.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            DG_NEW.Location = new Point(12, 12);
            DG_NEW.Name = "DG_NEW";
            DG_NEW.RowTemplate.Height = 25;
            DG_NEW.Size = new Size(760, 348);
            DG_NEW.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Frage";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Fragetyp";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "RichtigeAntwort";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Antwort_A";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Antwort_B";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Antwort_C";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Antwort_D";
            Column7.Name = "Column7";
            // 
            // TB_TABLENAME
            // 
            TB_TABLENAME.Location = new Point(12, 376);
            TB_TABLENAME.Name = "TB_TABLENAME";
            TB_TABLENAME.PlaceholderText = "Name Fragenkatalog";
            TB_TABLENAME.Size = new Size(181, 23);
            TB_TABLENAME.TabIndex = 1;
            // 
            // CMB_CAT_TODEL
            // 
            CMB_CAT_TODEL.FormattingEnabled = true;
            CMB_CAT_TODEL.Location = new Point(509, 376);
            CMB_CAT_TODEL.Name = "CMB_CAT_TODEL";
            CMB_CAT_TODEL.Size = new Size(263, 23);
            CMB_CAT_TODEL.TabIndex = 2;
            // 
            // BTN_ADD_CAT
            // 
            BTN_ADD_CAT.Location = new Point(12, 426);
            BTN_ADD_CAT.Name = "BTN_ADD_CAT";
            BTN_ADD_CAT.Size = new Size(181, 23);
            BTN_ADD_CAT.TabIndex = 3;
            BTN_ADD_CAT.Text = "Katalog Hinzufügen";
            BTN_ADD_CAT.UseVisualStyleBackColor = true;
            BTN_ADD_CAT.Click += BTN_ADD_CAT_Click;
            // 
            // BTN_DEL_TAB
            // 
            BTN_DEL_TAB.Location = new Point(581, 426);
            BTN_DEL_TAB.Name = "BTN_DEL_TAB";
            BTN_DEL_TAB.Size = new Size(181, 23);
            BTN_DEL_TAB.TabIndex = 4;
            BTN_DEL_TAB.Text = "Katalog Löschen";
            BTN_DEL_TAB.UseVisualStyleBackColor = true;
            BTN_DEL_TAB.Click += BTN_DEL_TAB_Click;
            // 
            // QuestEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Back;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(BTN_DEL_TAB);
            Controls.Add(BTN_ADD_CAT);
            Controls.Add(CMB_CAT_TODEL);
            Controls.Add(TB_TABLENAME);
            Controls.Add(DG_NEW);
            DoubleBuffered = true;
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "QuestEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuestEdit";
            ((System.ComponentModel.ISupportInitialize)DG_NEW).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DG_NEW;
        private TextBox TB_TABLENAME;
        private ComboBox CMB_CAT_TODEL;
        private Button BTN_ADD_CAT;
        private Button BTN_DEL_TAB;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}