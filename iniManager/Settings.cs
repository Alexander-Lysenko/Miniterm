namespace SettingsManager {
    public static class Settings {
        public static string SaltPass;
        public static byte DeviceNumber;
        public static string DeviсeName;
        public static string ComPortName;
        public static int BaudRate;
        public static int ArchiveFrequency;

        static Settings() {
            ArchiveFrequency = 10;
            BaudRate = 19200;
            ComPortName = "COM1";
            DeviсeName = "Печь";
            DeviceNumber = 0;
            SaltPass = "83";
        }

        public static void Save() {
            Ini.Write(SectionName.Authorization, "SaltPass", SaltPass);
            Ini.Write(SectionName.DataPicker, "DeviceNumber", DeviceNumber.ToString());
            Ini.Write(SectionName.DataPicker, "DeviсeName", DeviсeName);
            Ini.Write(SectionName.DataPicker, "ComPortName", ComPortName);
            Ini.Write(SectionName.DataPicker, "BaudRate", BaudRate.ToString());
            Ini.Write(SectionName.DataPicker, "ArchiveFrequency", ArchiveFrequency.ToString());
        }

        public static void Get() {
            SaltPass = Ini.VerifyKey(SectionName.Authorization, "SaltPass", SaltPass);
            DeviceNumber = byte.Parse(Ini.VerifyKey(SectionName.DataPicker, "DeviceNumber", DeviceNumber));
            DeviсeName = Ini.VerifyKey(SectionName.DataPicker, "DeviсeName", DeviсeName);
            ComPortName = Ini.VerifyKey(SectionName.DataPicker, "ComPortName", ComPortName);
            BaudRate = int.Parse(Ini.VerifyKey(SectionName.DataPicker, "BaudRate", BaudRate));
            ArchiveFrequency = int.Parse(Ini.VerifyKey(SectionName.DataPicker, "ArchiveFrequency", ArchiveFrequency));
        }
    }
}
