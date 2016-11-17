using System.Collections.Generic;

namespace ComManager
{
    public interface IComPort
    {
        List<ushort> Address { get; }

        void Close();
        void Open(string portName, int baudRate);
        ushort Read();
        void Write(ushort addres, byte deviceNumber);
    }
}