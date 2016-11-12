using System;
using System.Drawing;
using ZedGraph;

namespace GraphManager {
    public class Graph : IGraph {
        private readonly ZedGraphControl _graph;
        private PointPairList _temperature;
        private PointPairList _task;

        public Graph(ZedGraphControl graph) {
            _graph = graph;
            DrawGraph();
        }

        private void DrawGraph() {
            // Получим панель для рисования
            GraphPane pane = _graph.GraphPane;
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();
            // Создадим список точек
            _temperature = new PointPairList();
            _task = new PointPairList();
            pane.XAxis.Type = AxisType.Date;
            pane.XAxis.Scale.Format = "HH:mm:ss\ndd.MM.yyyy";
            pane.XAxis.Scale.MajorUnit = DateUnit.Hour;
            pane.XAxis.Scale.MinorUnit = DateUnit.Second;

            // Щрифт меток
            pane.XAxis.Scale.FontSpec.Size = pane.YAxis.Scale.FontSpec.Size = 8;

            // Включаем отображение сетки по осям
            pane.XAxis.MajorGrid.IsVisible = pane.YAxis.MajorGrid.IsVisible = true;
            pane.XAxis.MinorGrid.IsVisible = pane.YAxis.MinorGrid.IsVisible = true;

            // Задаем вид пунктирной линии по осям:
            pane.XAxis.MajorGrid.DashOn = pane.YAxis.MajorGrid.DashOn = 2;
            pane.XAxis.MajorGrid.DashOff = pane.YAxis.MajorGrid.DashOff = 0;
            pane.XAxis.MinorGrid.DashOn = pane.YAxis.MinorGrid.DashOn = 1;
            pane.XAxis.MinorGrid.DashOff = pane.YAxis.MinorGrid.DashOff = 1;

            // Подпись осей
            pane.XAxis.Title.Text = "";
            pane.YAxis.Title.Text = "Температура, °С";
            pane.YAxis.Title.FontSpec.Size = 10;
            pane.Title.Text = "";

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

            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem temperatureLine = pane.AddCurve("Температура", _temperature, Color.Red, SymbolType.None);
            LineItem taskLine = pane.AddCurve("Задание", _task, Color.Black, SymbolType.None);
            taskLine.Line.Width = 3;
            temperatureLine.Line.Width = 2;
            temperatureLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

            // Оьнавляем данные об осях. 
            _graph.AxisChange();

            // Обновляем график
            _graph.Invalidate();
        }

        public void Add(XDate dateX, double temperatureY, double taskY){
            _temperature.Add(dateX, temperatureY);
            _task.Add(dateX, taskY);
            _graph.AxisChange();
            _graph.Invalidate();
        }
    }
}
