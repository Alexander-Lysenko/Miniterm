namespace UI_DataPicker
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Status_Bar = new System.Windows.Forms.StatusStrip();
            this.TimeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphicTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchiveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.YOutputLabel = new System.Windows.Forms.Label();
            this.Temperature2Label = new System.Windows.Forms.Label();
            this.TXCLabel = new System.Windows.Forms.Label();
            this.TaskTemperatureLabel = new System.Windows.Forms.Label();
            this.CurrentTemperatureLabel = new System.Windows.Forms.Label();
            this.DeviceNameLabel = new System.Windows.Forms.Label();
            this.DeviceNumberLabel = new System.Windows.Forms.Label();
            this.PickerTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeTimer = new System.Windows.Forms.Timer(this.components);
            this.Status_Bar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status_Bar
            // 
            this.Status_Bar.BackColor = System.Drawing.Color.Transparent;
            this.Status_Bar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status_Bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeStatusLabel,
            this.DateStatusLabel});
            this.Status_Bar.Location = new System.Drawing.Point(0, 246);
            this.Status_Bar.Name = "Status_Bar";
            this.Status_Bar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Status_Bar.ShowItemToolTips = true;
            this.Status_Bar.Size = new System.Drawing.Size(284, 35);
            this.Status_Bar.SizingGrip = false;
            this.Status_Bar.Stretch = false;
            this.Status_Bar.TabIndex = 0;
            // 
            // TimeStatusLabel
            // 
            this.TimeStatusLabel.Name = "TimeStatusLabel";
            this.TimeStatusLabel.Size = new System.Drawing.Size(89, 30);
            this.TimeStatusLabel.Text = "11:00:00";
            this.TimeStatusLabel.ToolTipText = "Текущее время";
            // 
            // DateStatusLabel
            // 
            this.DateStatusLabel.Name = "DateStatusLabel";
            this.DateStatusLabel.Size = new System.Drawing.Size(111, 30);
            this.DateStatusLabel.Text = "31.12.2016";
            this.DateStatusLabel.ToolTipText = "Текущая дата";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsTSMI,
            this.GraphicTSMI,
            this.ArchiveTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SettingsTSMI
            // 
            this.SettingsTSMI.Image = ((System.Drawing.Image)(resources.GetObject("SettingsTSMI.Image")));
            this.SettingsTSMI.Name = "SettingsTSMI";
            this.SettingsTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.SettingsTSMI.Size = new System.Drawing.Size(95, 20);
            this.SettingsTSMI.Text = "Настройки";
            this.SettingsTSMI.Click += new System.EventHandler(this.SettingsTSMI_Click);
            // 
            // GraphicTSMI
            // 
            this.GraphicTSMI.Image = global::UI_MiniTerm.Properties.Resources.graphic;
            this.GraphicTSMI.Name = "GraphicTSMI";
            this.GraphicTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.GraphicTSMI.Size = new System.Drawing.Size(76, 20);
            this.GraphicTSMI.Text = "График";
            this.GraphicTSMI.Click += new System.EventHandler(this.GraphicTSMI_Click);
            // 
            // ArchiveTSMI
            // 
            this.ArchiveTSMI.Image = global::UI_MiniTerm.Properties.Resources.archive;
            this.ArchiveTSMI.Name = "ArchiveTSMI";
            this.ArchiveTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ArchiveTSMI.Size = new System.Drawing.Size(68, 20);
            this.ArchiveTSMI.Text = "Архив";
            this.ArchiveTSMI.Click += new System.EventHandler(this.ArchiveTSMI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Температура";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Задание";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Т. х. с.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Температура 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Выход Y";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Режим:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModeLabel
            // 
            this.ModeLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModeLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.ModeLabel.Location = new System.Drawing.Point(96, 208);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(181, 24);
            this.ModeLabel.TabIndex = 13;
            this.ModeLabel.Text = "Автонастройка";
            this.ModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YOutputLabel
            // 
            this.YOutputLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YOutputLabel.Location = new System.Drawing.Point(201, 179);
            this.YOutputLabel.Name = "YOutputLabel";
            this.YOutputLabel.Size = new System.Drawing.Size(76, 23);
            this.YOutputLabel.TabIndex = 12;
            this.YOutputLabel.Text = "000.00";
            this.YOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.YOutputLabel.Visible = false;
            // 
            // Temperature2Label
            // 
            this.Temperature2Label.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Temperature2Label.ForeColor = System.Drawing.Color.OrangeRed;
            this.Temperature2Label.Location = new System.Drawing.Point(201, 149);
            this.Temperature2Label.Name = "Temperature2Label";
            this.Temperature2Label.Size = new System.Drawing.Size(76, 23);
            this.Temperature2Label.TabIndex = 11;
            this.Temperature2Label.Text = "000.00";
            this.Temperature2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Temperature2Label.Visible = false;
            // 
            // TXCLabel
            // 
            this.TXCLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TXCLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.TXCLabel.Location = new System.Drawing.Point(201, 119);
            this.TXCLabel.Name = "TXCLabel";
            this.TXCLabel.Size = new System.Drawing.Size(76, 23);
            this.TXCLabel.TabIndex = 10;
            this.TXCLabel.Text = "000.00";
            this.TXCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TaskTemperatureLabel
            // 
            this.TaskTemperatureLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskTemperatureLabel.Location = new System.Drawing.Point(201, 89);
            this.TaskTemperatureLabel.Name = "TaskTemperatureLabel";
            this.TaskTemperatureLabel.Size = new System.Drawing.Size(76, 23);
            this.TaskTemperatureLabel.TabIndex = 9;
            this.TaskTemperatureLabel.Text = "000.00";
            this.TaskTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CurrentTemperatureLabel
            // 
            this.CurrentTemperatureLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentTemperatureLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.CurrentTemperatureLabel.Location = new System.Drawing.Point(201, 59);
            this.CurrentTemperatureLabel.Name = "CurrentTemperatureLabel";
            this.CurrentTemperatureLabel.Size = new System.Drawing.Size(76, 23);
            this.CurrentTemperatureLabel.TabIndex = 8;
            this.CurrentTemperatureLabel.Text = "000.00";
            this.CurrentTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DeviceNameLabel
            // 
            this.DeviceNameLabel.AutoEllipsis = true;
            this.DeviceNameLabel.BackColor = System.Drawing.Color.Yellow;
            this.DeviceNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeviceNameLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceNameLabel.Location = new System.Drawing.Point(71, 30);
            this.DeviceNameLabel.Name = "DeviceNameLabel";
            this.DeviceNameLabel.Size = new System.Drawing.Size(206, 25);
            this.DeviceNameLabel.TabIndex = 15;
            this.DeviceNameLabel.Text = "Печь №15";
            // 
            // DeviceNumberLabel
            // 
            this.DeviceNumberLabel.BackColor = System.Drawing.Color.GreenYellow;
            this.DeviceNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeviceNumberLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceNumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeviceNumberLabel.Location = new System.Drawing.Point(12, 30);
            this.DeviceNumberLabel.Name = "DeviceNumberLabel";
            this.DeviceNumberLabel.Size = new System.Drawing.Size(60, 25);
            this.DeviceNumberLabel.TabIndex = 14;
            this.DeviceNumberLabel.Text = "№ 15";
            // 
            // PickerTimer
            // 
            this.PickerTimer.Interval = 500;
            this.PickerTimer.Tick += new System.EventHandler(this.PickerTimer_Tick);
            // 
            // TimeTimer
            // 
            this.TimeTimer.Interval = 50;
            this.TimeTimer.Tick += new System.EventHandler(this.TimeTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.DeviceNameLabel);
            this.Controls.Add(this.DeviceNumberLabel);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.YOutputLabel);
            this.Controls.Add(this.Temperature2Label);
            this.Controls.Add(this.TXCLabel);
            this.Controls.Add(this.TaskTemperatureLabel);
            this.Controls.Add(this.CurrentTemperatureLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status_Bar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Минитерм";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Status_Bar.ResumeLayout(false);
            this.Status_Bar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Status_Bar;
        private System.Windows.Forms.ToolStripStatusLabel DateStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel TimeStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingsTSMI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.Label YOutputLabel;
        private System.Windows.Forms.Label Temperature2Label;
        private System.Windows.Forms.Label TXCLabel;
        private System.Windows.Forms.Label TaskTemperatureLabel;
        private System.Windows.Forms.Label CurrentTemperatureLabel;
        private System.Windows.Forms.Label DeviceNameLabel;
        private System.Windows.Forms.Label DeviceNumberLabel;
        private System.Windows.Forms.Timer PickerTimer;
        private System.Windows.Forms.ToolStripMenuItem GraphicTSMI;
        private System.Windows.Forms.ToolStripMenuItem ArchiveTSMI;
        private System.Windows.Forms.Timer TimeTimer;
    }
}

