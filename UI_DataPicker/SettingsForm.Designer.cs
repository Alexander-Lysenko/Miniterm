namespace UI_DataPicker
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.DeviceNumberNUD = new System.Windows.Forms.NumericUpDown();
            this.DeviceNameTB = new System.Windows.Forms.TextBox();
            this.ComListCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BaudRateCB = new System.Windows.Forms.ComboBox();
            this.ArchiveFrequencyCB = new System.Windows.Forms.ComboBox();
            this.SaltPassTB = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceNumberNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер прибора";
            // 
            // DeviceNumberNUD
            // 
            this.DeviceNumberNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceNumberNUD.Location = new System.Drawing.Point(205, 13);
            this.DeviceNumberNUD.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.DeviceNumberNUD.Name = "DeviceNumberNUD";
            this.DeviceNumberNUD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DeviceNumberNUD.Size = new System.Drawing.Size(117, 22);
            this.DeviceNumberNUD.TabIndex = 1;
            this.DeviceNumberNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DeviceNumberNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DeviceNameTB
            // 
            this.DeviceNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceNameTB.Location = new System.Drawing.Point(205, 39);
            this.DeviceNameTB.Name = "DeviceNameTB";
            this.DeviceNameTB.Size = new System.Drawing.Size(117, 22);
            this.DeviceNameTB.TabIndex = 2;
            this.DeviceNameTB.Text = "Печь";
            // 
            // ComListCB
            // 
            this.ComListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComListCB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComListCB.FormattingEnabled = true;
            this.ComListCB.Location = new System.Drawing.Point(205, 65);
            this.ComListCB.Name = "ComListCB";
            this.ComListCB.Size = new System.Drawing.Size(117, 24);
            this.ComListCB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название объекта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер COM-порта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Скорость обмена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Частота записи в архив";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Номер цеха (для пароля)";
            // 
            // BaudRateCB
            // 
            this.BaudRateCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRateCB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BaudRateCB.FormattingEnabled = true;
            this.BaudRateCB.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BaudRateCB.Location = new System.Drawing.Point(205, 92);
            this.BaudRateCB.Name = "BaudRateCB";
            this.BaudRateCB.Size = new System.Drawing.Size(117, 24);
            this.BaudRateCB.TabIndex = 4;
            // 
            // ArchiveFrequencyCB
            // 
            this.ArchiveFrequencyCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArchiveFrequencyCB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArchiveFrequencyCB.FormattingEnabled = true;
            this.ArchiveFrequencyCB.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "30",
            "60"});
            this.ArchiveFrequencyCB.Location = new System.Drawing.Point(205, 119);
            this.ArchiveFrequencyCB.Name = "ArchiveFrequencyCB";
            this.ArchiveFrequencyCB.Size = new System.Drawing.Size(55, 24);
            this.ArchiveFrequencyCB.TabIndex = 5;
            // 
            // SaltPassTB
            // 
            this.SaltPassTB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaltPassTB.Location = new System.Drawing.Point(205, 146);
            this.SaltPassTB.Name = "SaltPassTB";
            this.SaltPassTB.Size = new System.Drawing.Size(117, 23);
            this.SaltPassTB.TabIndex = 6;
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Location = new System.Drawing.Point(12, 194);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(310, 50);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Закрыть окно без изменения данных";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.Location = new System.Drawing.Point(12, 250);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(310, 50);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Сохранить данные и закрыть";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(265, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "секунд";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(334, 312);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SaltPassTB);
            this.Controls.Add(this.ArchiveFrequencyCB);
            this.Controls.Add(this.BaudRateCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComListCB);
            this.Controls.Add(this.DeviceNameTB);
            this.Controls.Add(this.DeviceNumberNUD);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.Text = "Настройки ";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeviceNumberNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown DeviceNumberNUD;
        private System.Windows.Forms.TextBox DeviceNameTB;
        private System.Windows.Forms.ComboBox ComListCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox BaudRateCB;
        private System.Windows.Forms.ComboBox ArchiveFrequencyCB;
        private System.Windows.Forms.TextBox SaltPassTB;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label7;
    }
}