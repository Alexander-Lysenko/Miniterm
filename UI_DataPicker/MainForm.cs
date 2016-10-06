using System;
using System.Windows.Forms;
using ComPort;
using UI_MiniTerm;

namespace UI_DataPicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PickerTimer.Start();
        }

        private void SettingsTSMI_Click(object sender, System.EventArgs e)
        {
            SettingsForm.ShowForm();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogoutForm.ShowForm();
            e.Cancel = true;
        }

        private void PickerTimer_Tick(object sender, System.EventArgs e)
        {
            DateStatusLabel.Text = DateTime.Now.ToShortDateString();
            TimeStatusLabel.Text = DateTime.Now.ToLongTimeString();
            PickerTimer.Stop();
            
            try {
                ComConnect Connection = new ComConnect(SettingsDP.settings["COMPortName"],
                    Convert.ToInt32(SettingsDP.settings["BaudRate"]));
                int[] response = Connection.ReadData();
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
