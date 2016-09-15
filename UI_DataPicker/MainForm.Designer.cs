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
            this.Status_Bar = new System.Windows.Forms.StatusStrip();
            this.DateStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Status_Bar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status_Bar
            // 
            this.Status_Bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeStatusLabel,
            this.DateStatusLabel});
            this.Status_Bar.Location = new System.Drawing.Point(0, 240);
            this.Status_Bar.Name = "Status_Bar";
            this.Status_Bar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Status_Bar.ShowItemToolTips = true;
            this.Status_Bar.Size = new System.Drawing.Size(284, 22);
            this.Status_Bar.TabIndex = 0;
            // 
            // DateStatusLabel
            // 
            this.DateStatusLabel.Name = "DateStatusLabel";
            this.DateStatusLabel.Size = new System.Drawing.Size(61, 17);
            this.DateStatusLabel.Text = "31.12.2016";
            this.DateStatusLabel.ToolTipText = "Текущая дата";
            // 
            // TimeStatusLabel
            // 
            this.TimeStatusLabel.Name = "TimeStatusLabel";
            this.TimeStatusLabel.Size = new System.Drawing.Size(49, 17);
            this.TimeStatusLabel.Text = "11:00:00";
            this.TimeStatusLabel.ToolTipText = "Текущее время";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SettingsTSMI
            // 
            this.SettingsTSMI.Name = "SettingsTSMI";
            this.SettingsTSMI.Size = new System.Drawing.Size(79, 20);
            this.SettingsTSMI.Text = "Настройки";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Status_Bar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Минитерм";
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
    }
}

