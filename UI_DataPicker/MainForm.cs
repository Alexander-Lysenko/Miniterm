using Logic_DataPicker;
using System.Windows.Forms;

namespace UI_DataPicker
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public int DeviceNumber
        {
            set { DeviceNumberLabel.Text = "№ " + value; }
        }

        public string DeviceName
        {
            set { DeviceNameLabel.Text = value; }
        }

        public string Date
        {
            set { DateStatusLabel.Text = value; }
        }

        public void SetData(string CurrentTemperature, string Temperature2, 
            string TaskTemperature, string txc, string OutputY, string Mode, string Time)
        {
            CurrentTemperatureLabel.Text = CurrentTemperature;
            TaskTemperatureLabel.Text = TaskTemperature;
            Temperature2Label.Text = Temperature2;
            TXCLabel.Text = txc;
            YOutputLabel.Text = OutputY;
            ModeLabel.Text = Mode;
            TimeStatusLabel.Text = Time;
        }
    }
}
