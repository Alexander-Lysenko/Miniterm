using System;
using System.Collections.Generic;
using System.Text;
using Presenters;

namespace Logic_DataPicker
{
    public interface IMainView : IView
    {
        int DeviceNumber { set; }
        string DeviceName { set; }
        string Date { set; }
        void SetData(string CurrentTemperature, string Temperature2, string TaskTemperature, string txc, 
            string OutputY, string Mode, string Time);
    }
}
