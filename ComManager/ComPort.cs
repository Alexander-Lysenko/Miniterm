using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;

namespace ComPort {
    public class ComConnect {
        private readonly List<ushort> _address = new List<ushort>(){
            0x10DA, //Регулируемая температура
            0x1018, //Задание
            0x112E, //Т.Х.С.
            0x101C, //Текущий режим прибора
        };

        private const byte Head = 0xEE;
        private const byte ErrorMessage = 0x7A;
        private const byte CommandNumber = 4;
        private byte _deviceNumber;
        private SerialPort _comPort;
        private int[] _response;

        public static string[] GetPortName() {
            string[] portNames = SerialPort.GetPortNames();
            if (portNames.Length != 0)
                return portNames;
            throw new Exception("На вашем устройстве нет активных COM-портов");
        }

        public void Open(string portName, int baudRate, byte deviceNumber) {
            Close();
            _deviceNumber = deviceNumber;
            _comPort = new SerialPort(portName, baudRate);
            _comPort.Open();
        }

        private void WriteData(int addressNumber) {
            ushort addr = _address[addressNumber];
            byte addrl = (byte)addr;
            byte addrh = (byte)(addr >> 8);
            byte[] request = {
                Head,
                (byte)(CommandNumber << 4 | _deviceNumber),
                addrl,
                addrh,
                (byte)(addrl + addrh)
            };
            _comPort.Write(request, 0, 5);
        }

        public void Write() {
            for (int i = 0; i < _address.Count; i++)
                WriteData(i);
        }

        public void Read() {
            _response = new int[_address.Count];
            for (int i = 0; i < _address.Count; i++) 
                _response[i] = ReadData();
        }

        private void WriteRead() {
            _response = new int[_address.Count];
            for (int i = 0; i < _address.Count; i++) {
                WriteData(i);
                _response[i] = ReadData();
            }
        }

        private int ReadData() {
            int oneByte = _comPort.ReadByte();
            if (oneByte == ErrorMessage && oneByte != 0x60)
                throw new Exception("Команда не распознана");
            byte datal = (byte)_comPort.ReadByte();
            byte datah = (byte)(_comPort.ReadByte() << 8);
            if (_comPort.ReadByte() != (byte)(datal + datah))
                return datal | datah;
            throw new Exception("Контрольная сумма не совпадает");
        }

        public void Close() {
            _comPort?.Close();
        }
    }
}
