using System;
using System.Threading;
using System.Windows.Forms;
using GraphManager;
using ZedGraph;

namespace UI_Visualizator {
    public partial class Visualizator : Form
    {
        public Visualizator()
        {
            InitializeComponent();
            _graph = new Graph(zedGraph);
            _lolT = new Thread(Lol);
            _lolT.Start();
        }

        private readonly Thread _lolT;
        private readonly IGraph _graph;
        
 

        private void updateTimer_Tick(object sender, EventArgs e)
        {
              
        }

        private void Lol() {
            for (;;) {
                _graph.Add(new XDate(DateTime.Now), new Random().Next(50, 110), 100);
                Thread.Sleep(1000);
            }
        }

        private void Visualizator_Load(object sender, EventArgs e)
        {
            updateTimer.Start();
        }

        private void Visualizator_FormClosing(object sender, FormClosingEventArgs e)
        {
            _lolT.Abort();
        }
    }
}
