using System;
using System.Threading;
using System.Windows.Forms;
using ComPort;
using FileManager;
using SettingsManager;

namespace UI_DataPicker {

    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private IComConnect _connection;
        private IFileManagerWrite _fileManagerWrite;

        public void RefreshFormData() {
            try {
                _connection.Open(Settings.ComPortName,
                    Convert.ToInt32(Settings.BaudRate), Settings.DeviceNumber);
                _connection.Write();
                PickerTimer.Interval = Settings.ArchiveFrequency * 1000;
                PickerTimer.Start();
            } catch (Exception ex) {
                ErrorMassager(ex.Message, "Внимание");
            } finally {
                DeviceNumberLabel.Text = "№ " + Settings.DeviceNumber;
                DeviceNameLabel.Text = Settings.DeviсeName;
            }
        }

        private void SettingsTSMI_Click(object sender, EventArgs e) {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
            RefreshFormData();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (LogoutForm.ShowForm()) {
                _connection.Close();
                _fileManagerWrite.Close();
                Application.ExitThread();
            }
            e.Cancel = true;
        }

        private void PickerTimer_Tick(object sender, EventArgs e) {
            try {
                _connection.Write();
                int[] response = _connection.Read();
                CurrentTemperatureLabel.Text = response[0].ToString();
                TaskTemperatureLabel.Text = response[1].ToString();
                TXCLabel.Text = response[2].ToString();
                ModeLabel.Text = response[3].ToString();
                new Thread(FileWrite).Start(response);
            } catch (Exception ex) {
                ErrorMassager(ex.Message, "Внимание");
                _connection.Close();
            }
        }

        private void FileWrite(object response) {
            string writeText = DateTime.Now.ToLongTimeString() + ";";
            foreach (var s in (int[])response)
                writeText += s + ";";
            _fileManagerWrite.Write(writeText + "0;0;");
        }

        private void GraphicTSMI_Click(object sender, EventArgs e) {
        }

        private void ArchiveTSMI_Click(object sender, EventArgs e) {
        }

        private void MainForm_Load(object sender, EventArgs e) {
            DateStatusLabel.Text = DateTime.Now.ToShortDateString();
            _connection = new ComConnect();
            _fileManagerWrite = new FileManagerWrite();
            RefreshFormData();
        }

        private void Time_Tick(object sender, EventArgs e) {
            TimeStatusLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void ErrorMassager(string massage, string caption) {
            PickerTimer.Stop();
            MessageBox.Show(massage, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
