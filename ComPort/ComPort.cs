using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace ComPort
{
    public class ComConnect : ComPort.IComConnect
    {
        private List<ushort> _address = new List<ushort>(){ 
            0x10DA, //Регулируемая температура
            0x1018, //Задание
            0x112E, //Т.Х.С.
             //Темпиратура 2
            0x1020, //Выход аналоговый Y
            0x101C, //Текущий режим прибора

        };
        
        private SerialPort _comPort;    

        public static string[] GetPortName() {
            string[] PortNames = SerialPort.GetPortNames();
            if (PortNames.Length != 0)
                return PortNames;
            throw new ArgumentNullException("На вашем устройстве нет COM порта");
        }

        public void Connect(string portName, int baudRate) {
            _comPort = new SerialPort(portName, baudRate);
            _comPort.Open();
        }

        public float[] ReceiveData(){
            
            return null;
        }

        private void write(ushort address) { 
            
        }

        public void Close() {
            _comPort.Close();
        }
    }
}
