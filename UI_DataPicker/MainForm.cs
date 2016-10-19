using System;
using System.Windows.Forms;
using ComPort;
using UI_MiniTerm;

namespace UI_DataPicker {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}
        public void RefreshFormData()
        {
            DeviceNumberLabel.Text = "№ " + SettingsDP.DeviceNumber;
            DeviceNameLabel.Text = SettingsDP.DeviсeName;
            PickerTimer.Interval = SettingsDP.ArchiveFrequency*1000;
            PickerTimer.Start();

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

            //try {
            //    ComConnect connection = new ComConnect(SettingsDP.ComPortName,
            //        Convert.ToInt32(SettingsDP.BaudRate));
            //    int[] response = connection.ReadData(SettingsDP.DeviceNumber);
            //    CurrentTemperatureLabel.Text = response[0].ToString();
            //    TaskTemperatureLabel.Text = response[1].ToString();
            //    TXCLabel.Text = response[2].ToString();
            //} catch (Exception ex) {
            //    PickerTimer.Stop();
            //    MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

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
            TimeTimer.Start();
        }

        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            TimeStatusLabel.Text = DateTime.Now.ToLongTimeString();
        }
	}
}
