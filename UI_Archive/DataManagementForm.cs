using System;
using System.Windows.Forms;

namespace UI_Archive
{
    public partial class DataManagementForm : Form
    {
        public DataManagementForm()
        {
            InitializeComponent();
        }

        void ChooseDataFiles(DateTime today)
        {

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            ChooseDataFiles(datePicker.Value);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
