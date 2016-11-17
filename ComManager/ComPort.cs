using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;

namespace ComManager
{
    public class ComPort : IComPort
    {
        private readonly List<ushort> _address;
        public List<ushort> Address
        {
            get {
                if (_address != null)
                    return _address;
                throw new ArgumentNullException(nameof(_address));
            }
        }
        public ushort ReadDataa { get; private set; }

        private readonly SerialPort _comPort;


        public static string[] GetPortName()
        {
            string[] portNames = SerialPort.GetPortNames();
            if (portNames.Length != 0)
                return portNames;
            throw new Exception("На вашем устройстве нет активных COM-портов");
        }

        public ComPort()
        {
            _comPort = new SerialPort {
                DataBits = 8,
                Parity = Parity.None,
                StopBits = StopBits.One
            };
            _address = new List<ushort>{
                Protocol.CurrentTemperature,
                Protocol.TaskTemperature,
                Protocol.TXC,
                Protocol.Mode
            };
        }

        public void Open(string portName, int baudRate)
        {
            Close();
            _comPort.PortName = portName;
            _comPort.BaudRate = baudRate;
            _comPort.Open();
        }

        public void Write(ushort addres, byte deviceNumber)
        {
            byte addrl = (byte)addres;
            byte addrh = (byte)(addres >> 8);
            byte[] request = {
                    0xEE,
                    (byte) (4 << 4 | deviceNumber),
                    addrl,
                    addrh,
                    (byte) (addrl + addrh)
                };
            _comPort.Write(request, 0, 5);
        }

        public void Read()
        {
            byte oneByte = (byte)_comPort.ReadByte();
            if (oneByte != 0x60)
                throw new Exception("Команда не распознана");
            byte datal = (byte)_comPort.ReadByte();
            byte datah = (byte)(_comPort.ReadByte() << 8);
            if (_comPort.ReadByte() != datal + datah)
                throw new Exception("Контрольная сумма не совпадает");
            ReadDataa = (ushort)(datal | datah);
        }

        public void Close()
        {
            var thread = new Thread(t => {
                if (_comPort != null && _comPort.IsOpen)
                    _comPort.Close();
            });
            thread.Start();
            thread.Join();
        }
    }
}
