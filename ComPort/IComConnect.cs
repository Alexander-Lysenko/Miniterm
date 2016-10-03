using System;
namespace ComPort
{
    public interface IComConnect
    {
        void Close();
        void Connect(string portName, int baudRate);
    }
}
