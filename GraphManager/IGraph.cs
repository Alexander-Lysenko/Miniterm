using ZedGraph;

namespace GraphManager {
    public interface IGraph {
        void Add(XDate dateX, double temperatureY, double taskY);
    }
}