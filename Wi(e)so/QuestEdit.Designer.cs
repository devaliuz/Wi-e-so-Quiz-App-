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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestEdit));
            this.DG_NEW = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB_TABLENAME = new System.Windows.Forms.TextBox();
            this.CMB_CAT_TODEL = new System.Windows.Forms.ComboBox();
            this.BTN_ADD_CAT = new System.Windows.Forms.Button();
            this.BTN_DEL_TAB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_NEW)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_NEW
            // 
            this.DG_NEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_NEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DG_NEW.Location = new System.Drawing.Point(12, 12);
            this.DG_NEW.Name = "DG_NEW";
            this.DG_NEW.RowTemplate.Height = 25;
            this.DG_NEW.Size = new System.Drawing.Size(760, 348);
            this.DG_NEW.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Frage";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fragetyp";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RichtigeAntwort";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Antwort_A";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Antwort_B";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Antwort_C";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Antwort_D";
            this.Column7.Name = "Column7";
            // 
            // TB_TABLENAME
            // 
            this.TB_TABLENAME.Location = new System.Drawing.Point(12, 376);
            this.TB_TABLENAME.Name = "TB_TABLENAME";
            this.TB_TABLENAME.PlaceholderText = "Name Fragenkatalog";
            this.TB_TABLENAME.Size = new System.Drawing.Size(181, 23);
            this.TB_TABLENAME.TabIndex = 1;
            // 
            // CMB_CAT_TODEL
            // 
            this.CMB_CAT_TODEL.FormattingEnabled = true;
            this.CMB_CAT_TODEL.Location = new System.Drawing.Point(509, 376);
            this.CMB_CAT_TODEL.Name = "CMB_CAT_TODEL";
            this.CMB_CAT_TODEL.Size = new System.Drawing.Size(263, 23);
            this.CMB_CAT_TODEL.TabIndex = 2;
            this.CMB_CAT_TODEL.SelectedIndexChanged += new System.EventHandler(this.CMB_CAT_TODEL_SelectedIndexChanged);
            // 
            // BTN_ADD_CAT
            // 
            this.BTN_ADD_CAT.Location = new System.Drawing.Point(12, 426);
            this.BTN_ADD_CAT.Name = "BTN_ADD_CAT";
            this.BTN_ADD_CAT.Size = new System.Drawing.Size(181, 23);
            this.BTN_ADD_CAT.TabIndex = 3;
            this.BTN_ADD_CAT.Text = "Katalog Hinzufügen";
            this.BTN_ADD_CAT.UseVisualStyleBackColor = true;
            this.BTN_ADD_CAT.Click += new System.EventHandler(this.BTN_ADD_CAT_Click);
            // 
            // BTN_DEL_TAB
            // 
            this.BTN_DEL_TAB.Location = new System.Drawing.Point(581, 426);
            this.BTN_DEL_TAB.Name = "BTN_DEL_TAB";
            this.BTN_DEL_TAB.Size = new System.Drawing.Size(181, 23);
            this.BTN_DEL_TAB.TabIndex = 4;
            this.BTN_DEL_TAB.Text = "Katalog Löschen";
            this.BTN_DEL_TAB.UseVisualStyleBackColor = true;
            this.BTN_DEL_TAB.Click += new System.EventHandler(this.BTN_DEL_TAB_Click);
            // 
            // QuestEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wi_e_so.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.BTN_DEL_TAB);
            this.Controls.Add(this.BTN_ADD_CAT);
            this.Controls.Add(this.CMB_CAT_TODEL);
            this.Controls.Add(this.TB_TABLENAME);
            this.Controls.Add(this.DG_NEW);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "QuestEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestEdit";
            ((System.ComponentModel.ISupportInitialize)(this.DG_NEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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