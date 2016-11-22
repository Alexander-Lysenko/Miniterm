namespace UI_Archive
{
    partial class DataManagementForm
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dataCollection = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.loginStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.usernameStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.settingsBtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePicker.Location = new System.Drawing.Point(12, 25);
            this.datePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(210, 24);
            this.datePicker.TabIndex = 1;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // dataCollection
            // 
            this.dataCollection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.dataCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataCollection.GridLines = true;
            this.dataCollection.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.dataCollection.Location = new System.Drawing.Point(228, 4);
            this.dataCollection.Name = "dataCollection";
            this.dataCollection.Size = new System.Drawing.Size(251, 293);
            this.dataCollection.TabIndex = 2;
            this.dataCollection.UseCompatibleStateImageBehavior = false;
            this.dataCollection.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Показать список данных за:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginStatusLbl,
            this.usernameStatusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 300);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // loginStatusLbl
            // 
            this.loginStatusLbl.Name = "loginStatusLbl";
            this.loginStatusLbl.Size = new System.Drawing.Size(164, 17);
            this.loginStatusLbl.Text = "Выполнен вход под именем:";
            // 
            // usernameStatusLbl
            // 
            this.usernameStatusLbl.Name = "usernameStatusLbl";
            this.usernameStatusLbl.Size = new System.Drawing.Size(118, 17);
            this.usernameStatusLbl.Text = "toolStripStatusLabel2";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Список данных";
            this.columnHeader1.Width = 220;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Location = new System.Drawing.Point(12, 274);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(210, 23);
            this.settingsBtn.TabIndex = 5;
            this.settingsBtn.Text = "Настроить...";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // DataManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 322);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataCollection);
            this.Controls.Add(this.datePicker);
            this.Name = "DataManagementForm";
            this.Text = "DataManagementForm";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ListView dataCollection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel loginStatusLbl;
        public System.Windows.Forms.ToolStripStatusLabel usernameStatusLbl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button settingsBtn;
    }
}