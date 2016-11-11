using System;
using System.Windows.Forms;
using ComPort;
using FileManager;
using SettingsManager;

namespace UI_DataPicker {
    public partial class LogoutForm : Form {
        public LogoutForm() {
            InitializeComponent();
        }

        private IComConnect _connection;
        private IFileManagerWrite _fileManagerWrite;

        public static void ShowForm(IComConnect comConnect, IFileManagerWrite fileManagerWrite) {
            LogoutForm logoutForm = new LogoutForm();
            logoutForm._connection = comConnect;
            logoutForm._fileManagerWrite = fileManagerWrite;
            logoutForm.ShowDialog();
            logoutForm.PasswordTB.Focus();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e) {
            if (PasswordTB.Text != DateTime.Now.Day + Settings.SaltPass) {
                Close();
                return;
            }
            _connection.Close();
            _fileManagerWrite.Close();
            Application.ExitThread();
        }

        private void CancelBtn_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
