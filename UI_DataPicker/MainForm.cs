using System;
using System.Windows.Forms;
using ComPort;
using SettingsManager;

namespace UI_DataPicker {

    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private IComConnect _connection;

        public void RefreshFormData() {
            try {
                _connection.Open(SettingsDp.ComPortName, 
                    Convert.ToInt32(SettingsDp.BaudRate), SettingsDp.DeviceNumber);
                _connection.Write();
                PickerTimer.Interval = SettingsDp.ArchiveFrequency * 1000;
                PickerTimer.Start();
                DeviceNumberLabel.Text = "№ " + SettingsDp.DeviceNumber;
                DeviceNameLabel.Text = SettingsDp.DeviсeName;
            } catch (Exception ex) {
                ErrorMassager(ex.Message, "Внимание");
            }
        }

        private void SettingsTSMI_Click(object sender, EventArgs e) {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            LogoutForm.ShowForm();
            e.Cancel = true;
        }

        private void PickerTimer_Tick(object sender, EventArgs e) {
            PickerTimer.Stop();
            try {
                _connection.Write();
                int[] response = _connection.Read();
                CurrentTemperatureLabel.Text = response[0].ToString();
                TaskTemperatureLabel.Text = response[1].ToString();
                TXCLabel.Text = response[2].ToString();
                ModeLabel.Text = response[3].ToString();
            } catch (Exception ex) {
                ErrorMassager(ex.Message, "Внимание");
            }

        }

        private void GraphicTSMI_Click(object sender, EventArgs e) {
        }

        private void ArchiveTSMI_Click(object sender, EventArgs e) {
        }

        private void MainForm_Load(object sender, EventArgs e) {
            DateStatusLabel.Text = DateTime.Now.ToShortDateString();
            _connection = new ComConnect();
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
