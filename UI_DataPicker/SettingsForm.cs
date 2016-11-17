using System;
using System.Windows.Forms;
using SettingsManager;

namespace UI_DataPicker {
	public partial class SettingsForm : Form {
		public SettingsForm() {
			InitializeComponent();
		}

		private void SaveBtn_Click(object sender, EventArgs e) {
			Settings.DeviceNumber = byte.Parse(DeviceNumberNUD.Value.ToString());
			Settings.DeviсeName = DeviceNameTB.Text;
			Settings.ComPortName = ComListCB.Text;
			Settings.BaudRate = int.Parse(BaudRateCB.Text);
			Settings.ArchiveFrequency = int.Parse(ArchiveFrequencyCB.Text);
			Settings.SaltPass = SaltPassTB.Text;
			Settings.Save();
			Close();
		}

		private void SettingsForm_Load(object sender, EventArgs e) {
            try
            {
                ComListCB.Items.AddRange(ComManager.ComPort.GetPortName());
                ComListCB.Text = Settings.ComPortName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Предупреждение", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            DeviceNumberNUD.Value = Convert.ToDecimal(Settings.DeviceNumber);
			DeviceNameTB.Text = Settings.DeviсeName;
			BaudRateCB.Text = Settings.BaudRate.ToString();
			ArchiveFrequencyCB.Text = Settings.ArchiveFrequency.ToString();
			SaltPassTB.Text = Settings.SaltPass;
		}
	}
}
