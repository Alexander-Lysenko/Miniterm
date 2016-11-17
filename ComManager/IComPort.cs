using System.Collections.Generic;

namespace ComManager
{
    public interface IComPort
    {
        List<ushort> Address { get; }
        ushort ReadDataa { get; }

        void Close();
        void Open(string portName, int baudRate);
        void Read();
        void Write(ushort addres, byte deviceNumber);
    }
}