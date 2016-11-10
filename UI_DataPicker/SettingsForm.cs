using System;
using System.Windows.Forms;
using SettingsManager;

namespace UI_DataPicker {
	public partial class SettingsForm : Form {
		public SettingsForm(MainForm mainForm) {
			InitializeComponent();
            _mainForm = mainForm;
		}

	    private readonly MainForm _mainForm;

		private void SaveBtn_Click(object sender, EventArgs e) {
			SettingsDp.DeviceNumber = byte.Parse(DeviceNumberNUD.Value.ToString());
			SettingsDp.DeviсeName = DeviceNameTB.Text;
			SettingsDp.ComPortName = ComListCB.Text;
			SettingsDp.BaudRate = int.Parse(BaudRateCB.Text);
			SettingsDp.ArchiveFrequency = int.Parse(ArchiveFrequencyCB.Text);
			SettingsDp.SaltPass = SaltPassTB.Text;
			SettingsDp.Save();
            _mainForm.RefreshFormData();
			Close();
		}

		private void SettingsForm_Load(object sender, EventArgs e) {
            try {
                ComListCB.Items.AddRange(ComPort.ComConnect.GetPortName());
                ComListCB.Text = SettingsDp.ComPortName;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            DeviceNumberNUD.Value = Convert.ToDecimal(SettingsDp.DeviceNumber);
			DeviceNameTB.Text = SettingsDp.DeviсeName;
			BaudRateCB.Text = SettingsDp.BaudRate.ToString();
			ArchiveFrequencyCB.Text = SettingsDp.ArchiveFrequency.ToString();
			SaltPassTB.Text = SettingsDp.SaltPass;
		}
	}
}
