using System;
using System.Windows.Forms;
using UI_MiniTerm;

namespace UI_DataPicker {
	public partial class SettingsForm : Form {
		public SettingsForm(MainForm mainForm) {
			InitializeComponent();
            _mainForm = mainForm;
		}

	    private readonly MainForm _mainForm;

		private void SaveBtn_Click(object sender, EventArgs e) {
			SettingsDP.DeviceNumber = byte.Parse(DeviceNumberNUD.Value.ToString());
			SettingsDP.DeviсeName = DeviceNameTB.Text;
			SettingsDP.ComPortName = ComListCB.Text;
			SettingsDP.BaudRate = int.Parse(BaudRateCB.Text);
			SettingsDP.ArchiveFrequency = int.Parse(ArchiveFrequencyCB.Text);
			SettingsDP.SaltPass = SaltPassTB.Text;
			SettingsDP.Save();
            _mainForm.RefreshFormData();
			Close();
		}

		private void SettingsForm_Load(object sender, EventArgs e) {
            try {
                ComListCB.Items.AddRange(ComPort.ComConnect.GetPortName());
                ComListCB.Text = SettingsDP.ComPortName;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //Close();
            }
            DeviceNumberNUD.Value = Convert.ToDecimal(SettingsDP.DeviceNumber);
			DeviceNameTB.Text = SettingsDP.DeviсeName;
			BaudRateCB.Text = SettingsDP.BaudRate.ToString();
			ArchiveFrequencyCB.Text = SettingsDP.ArchiveFrequency.ToString();
			SaltPassTB.Text = SettingsDP.SaltPass;
		}
	}
}
