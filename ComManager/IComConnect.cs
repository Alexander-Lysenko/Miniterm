namespace ComPort {
    public interface IComConnect {
        void Close();
        void Open(string portName, int baudRate, byte deviceNumber);
        int[] Read();
        void Write();
    }
}