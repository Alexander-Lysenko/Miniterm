using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;

namespace ComPort {
    public class ComConnect : IComConnect {
        private readonly List<ushort> _address;

        private SerialPort _comPort;
        private Thread _readThread;

        private byte _deviceNumber;
        private int[] _response;

        public static string[] GetPortName() {
            string[] portNames = SerialPort.GetPortNames();
            if (portNames.Length != 0)
                return portNames;
            throw new Exception("На вашем устройстве нет активных COM-портов");
        }

        public ComConnect() {
            _address = new List<ushort>{
                0x10DA, //Регулируемая температура
                0x1018, //Задание
                0x112E, //Т.Х.С.
                0x101C, //Текущий режим прибора
            };
        }

        public void Open(string portName, int baudRate, byte deviceNumber) {
            Close();
            _deviceNumber = deviceNumber;
            if (_comPort == null) {
                _comPort = new SerialPort();
            }
            _comPort.PortName = portName;
            _comPort.BaudRate = baudRate;
            _comPort.Open();
            Write();
            ReadStart();
        }

        private void WriteData() {
            for (int i = 0; i < _address.Count; i++) {
                ushort addr = _address[i];
                byte addrl = (byte)addr;
                byte addrh = (byte)(addr >> 8);
                byte[] request =
                {
                    0xEE,
                    (byte) (4 << 4 | _deviceNumber),
                    addrl,
                    addrh,
                    (byte) (addrl + addrh)
                };
                _comPort.Write(request, 0, 5);
            }
        }

        public void Write() {
            new Thread(WriteData).Start();
        }

        public int[] Read() {
            if (_readThread.Join(new TimeSpan(0, 0, 0, 0, 500))) {
                ReadStart();
                var response = _response;
                _response = new int[_address.Count];
                return response;
            }
            throw new Exception("Лимит ожидания превышен");
        }

        private void ReadData() {
            for (int i = 0; i < _address.Count; i++) {
                int oneByte = _comPort.ReadByte();
                if (oneByte == 0x7A && oneByte != 0x60)
                    throw new Exception("Команда не распознана");
                byte datal = (byte)_comPort.ReadByte();
                byte datah = (byte)(_comPort.ReadByte() << 8);
                if (_comPort.ReadByte() != (byte)(datal + datah))
                    _response[i] = datal | datah;
                throw new Exception("Контрольная сумма не совпадает");
            }
        }

        private void ReadStart() {
            _readThread = new Thread(ReadData);
            _readThread.Start();
        }

        public void Close() {
            if (_readThread != null)
                _readThread.Abort();
            if (_comPort != null)
                _comPort.Close();
        }
    }
}
