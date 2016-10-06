using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI_MiniTerm;

namespace UI_DataPicker
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }
        public static void ShowForm()
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SettingsDP.settings["DeviceNumber"] = DeviceNumberNUD.Value.ToString();
            SettingsDP.settings["DeviceName"] = DeviceNameTB.Text;
            SettingsDP.settings["COMPortName"] = ComListCB.Text;
            SettingsDP.settings["BaudRate"] = BaudRateCB.Text;
            SettingsDP.settings["ArchiveFrequency"] = ArchiveFrequencyCB.Text;
            SettingsDP.SaltPass = SaltPassTB.Text;
            Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            DeviceNumberNUD.Value = Convert.ToDecimal(SettingsDP.settings["DeviceNumber"]);
            DeviceNameTB.Text = SettingsDP.settings["DeviсeName"];
            ComListCB.Items.AddRange(ComPort.ComConnect.GetPortName());
            ComListCB.Text = SettingsDP.settings["COMPortName"];
            BaudRateCB.Text = SettingsDP.settings["BaudRate"];
            ArchiveFrequencyCB.Text = SettingsDP.settings["ArchiveFrequency"];
            SaltPassTB.Text = SettingsDP.SaltPass;
        }
    }
}
