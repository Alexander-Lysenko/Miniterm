﻿using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace ComPort
{
    public class ComConnect
    {
        private List<ushort> _address = new List<ushort>(){ 
            0x10DA, //Регулируемая температура
            0x1018, //Задание
            0x112E, //Т.Х.С.
             //Темпиратура 2
            0x1020, //Выход аналоговый Y
            0x101C, //Текущий режим прибора

        };

        private byte Head = 0xEE;
        private byte ErrorMessage = 0x7A;
        private byte CommandNumber = 4;
        
        private SerialPort _comPort;    

        public static string[] GetPortName() {
            string[] PortNames = SerialPort.GetPortNames();
            if (PortNames.Length != 0)
                return PortNames;
            throw new ArgumentNullException("На вашем устройстве нет COM порта");
        }

        public ComConnect(string portName, int baudRate) {
            _comPort = new SerialPort(portName, baudRate);
            _comPort.Open();
        }

        public ComConnect(string portName)
        {
            _comPort = new SerialPort(portName);
            _comPort.Open();
        }

        private void WriteData(ushort address) {
            byte N = 0; /*Номер прибора*/
            byte addrl = (byte)address;
            byte addrh = (byte)(address >> 8);
            byte[] request = new byte[]{
                Head, 
                (byte)(CommandNumber << 4 | N),
                addrl,
                addrh,
                (byte)(addrl + addrh)
            };
            _comPort.Write(request, 0, 5);
        }

        public int ReadData(ushort address)
        {
            WriteData(address);
            int OneByte = _comPort.ReadByte();
            if (OneByte == 0x7A)
                throw new Exception("Команда не распознана");
            return _comPort.ReadByte() | (_comPort.ReadByte() << 8);
        }

        public void Close() {
            _comPort.Close();
        }
    }
}
