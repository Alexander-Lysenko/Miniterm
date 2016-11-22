using System;
using System.Threading;
using System.Windows.Forms;
using FileManager;
using GraphManager;
using ZedGraph;

namespace UI_Visualizator
{
    public partial class Visualizator : Form
    {
        private readonly Thread _updateThread;
        private readonly IGraph _graph;
        private readonly IFileManagerRead _fileManager;

        public Visualizator(IFileManagerRead fileManagerRead)
        {
            InitializeComponent();
            _graph = new Graph(zedGraph);
            _fileManager = fileManagerRead;
            _updateThread = new Thread(Update);
            _updateThread.Start();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {

        }

        private void Update()
        {
            while (true)
            {
                string[] data = _fileManager.Read().Split(';');
                DateTime date = Convert.ToDateTime(data[0]);
                _graph.Add(new XDate(date), double.Parse(data[1]), double.Parse(data[2]));
                DateTime currentTime = DateTime.Now;
                if (currentTime.Hour - date.Hour == 0 && currentTime.Minute - date.Minute < 1)
                    Thread.Sleep(SettingsManager.Settings.ArchiveFrequency * 1000);
            }
        }

        private void Visualizator_Load(object sender, EventArgs e)
        {
            updateTimer.Start();
        }

        private void Visualizator_FormClosing(object sender, FormClosingEventArgs e)
        {
            _updateThread.Interrupt();
        }
    }
}
