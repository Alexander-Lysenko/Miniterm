using System;
using iniManager;

namespace UI_MiniTerm
{
    internal class SettingsDP
    {
        /*public static Dictionary<string, string> settings = new Dictionary<string, string>()
        {
            {"DeviceNumber", "0"},
            {"DeviсeName", "Печь"},
            {"ComPortName", "COM1"},
            {"BaudRate", "19200"},
            {"ArchiveFrequency", "5" }
        };*/
        public static string SaltPass = "83";
        public static byte DeviceNumber = 0;
        public static string DeviсeName = "Печь";
        public static string ComPortName = "COM1";
        public static int BaudRate = 19200;
        public static int ArchiveFrequency = 10;


        public static void Save()
        {
            ini.Write(SectionName.Authorization, "SaltPass", SaltPass);

            ini.Write(SectionName.DataPicker, "DeviceNumber", DeviceNumber.ToString());
            ini.Write(SectionName.DataPicker, "DeviсeName", DeviсeName);
            ini.Write(SectionName.DataPicker, "ComPortName", ComPortName);
            ini.Write(SectionName.DataPicker, "BaudRate", BaudRate.ToString());
            ini.Write(SectionName.DataPicker, "ArchiveFrequency", ArchiveFrequency.ToString());
        }

        public static void Get()
        {

            SaltPass = ini.ReadINI(SectionName.Authorization, "SaltPass");
            DeviceNumber = Byte.Parse(ini.ReadINI(SectionName.DataPicker, "DeviceNumber"));
            DeviсeName = ini.ReadINI(SectionName.DataPicker, "DeviсeName");
            ComPortName = ini.ReadINI(SectionName.DataPicker, "ComPortName");
            BaudRate = int.Parse(ini.ReadINI(SectionName.DataPicker, "BaudRate"));
            ArchiveFrequency = int.Parse(ini.ReadINI(SectionName.DataPicker, "ArchiveFrequency"));

            //if (ini.KeyExists(SectionName.Authorization, "SaltPass"))
            //    SaltPass = ini.ReadINI(SectionName.Authorization, "SaltPass");
            //else
            //    ini.Write(SectionName.Authorization, "SaltPass", SaltPass);

            //if (ini.KeyExists(SectionName.DataPicker, "DeviceNumber"))
            //    DeviceNumber = Byte.Parse(ini.ReadINI(SectionName.DataPicker, "DeviceNumber"));
            //else
            //    ini.Write(SectionName.DataPicker, "DeviceNumber", DeviceNumber.ToString());

            //if (ini.KeyExists(SectionName.DataPicker, "DeviсeName"))
            //    DeviсeName = ini.ReadINI(SectionName.DataPicker, "DeviсeName");
            //else
            //    ini.Write(SectionName.DataPicker, "DeviсeName", DeviсeName);

            //if (ini.KeyExists(SectionName.DataPicker, "ComPortName"))
            //    ComPortName = ini.ReadINI(SectionName.DataPicker, "ComPortName");
            //else
            //    ini.Write(SectionName.DataPicker, "ComPortName", ComPortName);

            //if (ini.KeyExists(SectionName.DataPicker, "BaudRate"))
            //    BaudRate = int.Parse(ini.ReadINI(SectionName.DataPicker, "BaudRate"));
            //else
            //    ini.Write(SectionName.DataPicker, "BaudRate", BaudRate.ToString());

            //if (ini.KeyExists(SectionName.DataPicker, "ArchiveFrequency"))
            //    ArchiveFrequency = int.Parse(ini.ReadINI(SectionName.DataPicker, "ArchiveFrequency"));
            //else
            //    ini.Write(SectionName.DataPicker, "ArchiveFrequency", ArchiveFrequency.ToString());
        }
    }
}
