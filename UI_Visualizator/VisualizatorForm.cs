using System;
using System.Threading;
using System.Windows.Forms;
using FileManager;
using GraphManager;
using ZedGraph;

namespace UI_Visualizator {
    public partial class Visualizator : Form {
        private readonly Thread _lolT;
        private readonly IGraph _graph;
        private readonly IFileManagerRead _fileManager;

        public Visualizator() {
            InitializeComponent();
            _graph = new Graph(zedGraph);
            _fileManager = new FileManagerRead(DateTime.Now);
            _lolT = new Thread(Lol);
            _lolT.Start();
        }

        private void updateTimer_Tick(object sender, EventArgs e) {

        }

        private void Lol() {
            while (true) {
                string[] data = _fileManager.Read().Split(';');
                DateTime date = Convert.ToDateTime(data[0]);
                _graph.Add(new XDate(date), double.Parse(data[1]), double.Parse(data[2]));
                Thread.Sleep(SettingsManager.Settings.ArchiveFrequency * 1000);
            }
        }

        private void Visualizator_Load(object sender, EventArgs e) {
            updateTimer.Start();
        }

        private void Visualizator_FormClosing(object sender, FormClosingEventArgs e) {
            _lolT.Abort();
        }
    }
}
