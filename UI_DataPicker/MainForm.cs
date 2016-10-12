using System;
using System.Windows.Forms;
using ComPort;
using UI_MiniTerm;

namespace UI_DataPicker {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
			PickerTimer.Start();
		}

		private void SettingsTSMI_Click(object sender, EventArgs e) {
			SettingsForm.ShowForm();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
			LogoutForm.ShowForm();
			e.Cancel = true;
		}

		private void PickerTimer_Tick(object sender, EventArgs e) {
			DateStatusLabel.Text = DateTime.Now.ToShortDateString();
			TimeStatusLabel.Text = DateTime.Now.ToLongTimeString();
			PickerTimer.Stop();

			try {
				ComConnect connection = new ComConnect(SettingsDP.ComPortName,
					Convert.ToInt32(SettingsDP.BaudRate));
				int[] response = connection.ReadData(SettingsDP.DeviceNumber);
				CurrentTemperatureLabel.Text = response[0].ToString();
				TaskTemperatureLabel.Text = response[1].ToString();
				TXCLabel.Text = response[2].ToString();
			} catch (Exception ex) {
				PickerTimer.Stop();
				MessageBox.Show(ex.Message);
			}

		}
	}
}
