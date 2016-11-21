using System;
using System.Collections.Generic;
using FileManager;
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
                throw new ArgumentNullException(/*nameof(_address)*/);
            }
        }

        private byte _readData;
        private Thread _threadRead;
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

        public ushort Read()
        {
            byte oneByte = ReaByte();
            if (oneByte != 0x60)
                throw new Exception("Команда не распознана");
            byte datal = ReaByte();
            byte datah = (byte)(_readData << 8);
            if (ReaByte() != datal + datah)
                throw new Exception("Контрольная сумма не совпадает");
            return (ushort)(datal | datah);
        }

        private byte ReaByte()
        {
            _threadRead = new Thread(
                t => {
                    try
                    {
                        _readData = (byte)_comPort.ReadByte();
                    }
                    catch (Exception ex)
                    {
                        LogiManager.Log(ex.Message);
                    }
                });
            _threadRead.Start();
            if (!_threadRead.Join(new TimeSpan(0, 0, 0, 0, 500)))
                throw new Exception("Превышен лимит ожидания");
            return _readData;
        }

        public void Close()
        {
            if (_threadRead != null) _threadRead.Interrupt();
            if (_comPort!=null) _comPort.Close();
        }
    }
}
