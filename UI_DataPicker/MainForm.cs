using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComManager;
using FileManager;
using SettingsManager;

namespace UI_DataPicker
{

    public partial class MainForm : Form
    {

        private readonly IComPort _connection;
        private readonly IFileManagerWrite _fileManagerWrite;

        public MainForm(IComPort connect, IFileManagerWrite fileManager)
        {
            InitializeComponent();
            _connection = connect;
            _fileManagerWrite = fileManager;
        }

        public void RefreshFormData()
        {
            try
            {
                _connection.Open(Settings.ComPortName, Convert.ToInt32(Settings.BaudRate));
                PickerTimer.Interval = Settings.ArchiveFrequency * 1000;
                PickerTimer.Start();
            }
            catch (Exception ex)
            {
                ErrorMessager(ex.Message, "Внимание");
            }
            finally
            {
                DeviceNumberLabel.Text = "№ " + Settings.DeviceNumber;
                DeviceNameLabel.Text = Settings.DeviсeName;
            }
        }

        private void SettingsTSMI_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
            RefreshFormData();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LogoutForm.ShowForm())
            {
                _connection.Close();
                _fileManagerWrite.Close();
                Application.ExitThread();
            }
            e.Cancel = true;
        }

        private void PickerTimer_Tick(object sender, EventArgs e)
        {
            List<Label> labels = new List<Label>(){
                     CurrentTemperatureLabel, TaskTemperatureLabel, TXCLabel, ModeLabel
            };
            
            try
            {
                for (int i = 0; i < _connection.Address.Count; i++)
                {
                    _connection.Write(_connection.Address[i], Settings.DeviceNumber);
                    labels[i].Text = _connection.Read().ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorMessager(ex.Message, "Ошибка!");
            }
        }

        private void GraphicTSMI_Click(object sender, EventArgs e)
        {
        }

        private void ArchiveTSMI_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateStatusLabel.Text = DateTime.Now.ToShortDateString();
            RefreshFormData();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            TimeStatusLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void ErrorMessager(string message, string caption)
        {
            PickerTimer.Stop();
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            LogiManager.Log(message);
        }
    }
}
