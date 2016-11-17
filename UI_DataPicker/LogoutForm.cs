using System;
using System.Windows.Forms;
using SettingsManager;

namespace UI_DataPicker {
    public partial class LogoutForm : Form {
        public LogoutForm() {
            InitializeComponent();
        }

        private bool _t = false;

        public static bool ShowForm() {
            LogoutForm logoutForm = new LogoutForm();
            logoutForm.PasswordTB.Focus();
            logoutForm.ShowDialog();
            return logoutForm._t;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e) {
            if (PasswordTB.Text == DateTime.Now.Day + Settings.SaltPass)
            {
                _t = true;
                Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
