using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ZedGraph;

namespace UI_Visualizator
{
    public partial class Visualizator : Form
    {
        public Visualizator()
        {
            InitializeComponent();
            DrawGraph();
            lolT = new Thread(lol);
            lolT.Start();
        }
        Thread lolT;
        PointPairList temperature;
        PointPairList task;
        
        private void DrawGraph()
        {
            // Получим панель для рисования
            GraphPane pane = zedGraph.GraphPane;
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();
            // Создадим список точек
            temperature = new PointPairList();
            task = new PointPairList();
            pane.XAxis.Type = AxisType.Date;
            pane.XAxis.Scale.Format = "HH:mm:ss\ndd.MM.yyyy";
            pane.XAxis.Scale.MajorUnit = DateUnit.Hour;
            pane.XAxis.Scale.MinorUnit = DateUnit.Second;

            // Немного уменьшим шрифт меток, чтобы их больше умещалось
            pane.XAxis.Scale.FontSpec.Size = 8;
            pane.YAxis.Scale.FontSpec.Size = 8;

            // Включаем отображение сетки по осям
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true; 
            pane.XAxis.MinorGrid.IsVisible = true;
            pane.YAxis.MinorGrid.IsVisible = true;

            // Задаем вид пунктирной линии по осям:
            pane.XAxis.MajorGrid.DashOn = 2;
            pane.YAxis.MajorGrid.DashOn = 2;
            pane.XAxis.MajorGrid.DashOff = 0;
            pane.YAxis.MajorGrid.DashOff = 0; 
            pane.XAxis.MinorGrid.DashOn = 1;
            pane.YAxis.MinorGrid.DashOn = 1;
            pane.XAxis.MinorGrid.DashOff = 1;
            pane.YAxis.MinorGrid.DashOff = 1;

            // Изменим тест надписи по оси X
            pane.XAxis.Title.Text = "";
            pane.YAxis.Title.Text = "Температура, °С";
            pane.YAxis.Title.FontSpec.Size = 10;
            pane.Title.Text = "";

            // !!!
            // Указываем, что расположение легенды мы будет задавать 
            // в виде координат левого нижнего угла
            pane.Legend.Position = LegendPos.InsideBotLeft;
            // Координаты будут отсчитываться в системе координат окна графика
            pane.Legend.Location.CoordinateFrame = CoordType.ChartFraction;

            // Задаем выравнивание, относительно которого мы будем задавать координаты
            // В данном случае мы будем располагать легенду справа внизу
            pane.Legend.Location.AlignH = AlignH.Left;
            pane.Legend.Location.AlignV = AlignV.Bottom;
            pane.Legend.FontSpec.Size = 8;

            // Создадим кривую с названием "Sinc", 
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem temperatureLine = pane.AddCurve("Температура", temperature, Color.Red, SymbolType.None);
            LineItem taskLine = pane.AddCurve("Задание", task, Color.Black, SymbolType.None);
            taskLine.Line.Width = 3;
            temperatureLine.Line.Width = 2;
            temperatureLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
              
        }

        private void lol() {
            for (; ; )
            {
                temperature.Add(new XDate(DateTime.Now), new Random().Next() % 100);
                task.Add(new XDate(DateTime.Now), 100);
                zedGraph.AxisChange();
                zedGraph.Invalidate();
                Thread.Sleep(500);
            }
        }

        private void Visualizator_Load(object sender, EventArgs e)
        {
            updateTimer.Start();
        }

        private void Visualizator_FormClosing(object sender, FormClosingEventArgs e)
        {
            lolT.Abort();
        }
    }
}
