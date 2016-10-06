using System;
using System.Collections.Generic;
using System.Text;
using iniManager;

namespace UI_MiniTerm {
    internal class SettingsDP
    {
        public static string SaltPass = "83";
        public static Dictionary<string, string> settings = new Dictionary<string, string>()
        {
            {"DeviceNumber", "0"},
            {"DeviсeName", "Печь"},
            {"COMPortName", "COM1"},
            {"BaudRate", "19200"},
            {"ArchiveFrequency", "5" }
        };

        public static void Save()
        {
            foreach (var setting in settings) {
                ini.Write(SectionName.DataPicker, setting.Key, setting.Value);
            }
            ini.Write(SectionName.Authorization, "SaltPass", SaltPass);
        }

        public static void Get()
        {
            foreach (var setting in settings) {
                if (ini.KeyExists(SectionName.DataPicker, setting.Key))
                    settings[setting.Key] =
                        ini.ReadINI(SectionName.DataPicker, setting.Key);
                else
                    ini.Write(SectionName.DataPicker, setting.Key, setting.Value);
            }
            if (ini.KeyExists(SectionName.Authorization, "SaltPass"))
                SaltPass = ini.ReadINI(SectionName.Authorization, "SaltPass");
            else
                ini.Write(SectionName.Authorization, "SaltPass", SaltPass);
        }
    }
}
