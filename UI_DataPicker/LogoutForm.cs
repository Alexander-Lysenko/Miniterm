using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_DataPicker
{
    public partial class LogoutForm : Form
    {
        public LogoutForm()
        {
            InitializeComponent();
        }
        public static void ShowForm() 
        {
            LogoutForm logoutForm = new LogoutForm();
            logoutForm.ShowDialog();
            logoutForm.PasswordTB.Focus();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тип я работаю");
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
