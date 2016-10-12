using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace ComPort {
    public class ComConnect {
        private List<ushort> _address = new List<ushort>(){
            0x10DA, //Регулируемая температура
            0x1018, //Задание
            0x112E, //Т.Х.С.
             //Темпиратура 2
            0x1020, //Выход аналоговый Y
            0x101C, //Текущий режим прибора

        };

        private byte _head = 0xEE;
        private byte _errorMessage = 0x7A;
        private byte _commandNumber = 4;

        private SerialPort _comPort;

        public static string[] GetPortName() {
            string[] PortNames = SerialPort.GetPortNames();
            if (PortNames.Length != 0)
                return PortNames;
            throw new Exception("На вашем устройстве нет активных COM-портов");
        }

        public ComConnect(string portName, int baudRate) {
            _comPort = new SerialPort(portName, baudRate);
            _comPort.Open();
        }

        private void WriteData(ushort address, byte DeviceNumber) {
           // byte N = 0; /*Номер прибора*/
            byte addrl = (byte)address;
            byte addrh = (byte)(address >> 8);
            byte[] request = /*new byte[]*/{
                _head,
                (byte)(_commandNumber << 4 | DeviceNumber),
                addrl,
                addrh,
                (byte)(addrl + addrh)
            };
            _comPort.Write(request, 0, 5);
        }

        public int[] ReadData(byte DeviceNumber) {
            int[] response = new int[3];
            for (int i = 0; i < 3; i++) {
                WriteData(_address[i], DeviceNumber);
                response[i] = Read();
            }
            return response;
        }

        private int Read() {
            int oneByte = _comPort.ReadByte();
            if (oneByte == 0x7A)
                throw new Exception("Команда не распознана");
            byte datal = (byte)_comPort.ReadByte();
            byte datah = (byte)(_comPort.ReadByte() << 8);
            return datal | datah;
        }

        public void Close() {
            _comPort.Close();
        }
    }
}
