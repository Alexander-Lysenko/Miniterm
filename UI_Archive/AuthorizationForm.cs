using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_Archive
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            DMF = new DataManagementForm();
        }
        DataManagementForm DMF;

        private void loginBtn_Click(object sender, EventArgs e)
        {
            DMF.usernameStatusLbl.Text = loginTB.Text;
            DMF.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
