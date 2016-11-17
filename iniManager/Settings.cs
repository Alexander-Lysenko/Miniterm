namespace SettingsManager
{
    public static class Settings
    {
        public static string SaltPass;
        public static byte DeviceNumber;
        public static string DeviсeName;
        public static string ComPortName;
        public static int BaudRate;
        public static int ArchiveFrequency;

        static Settings()
        {
            SaltPass = iniManager.VerifyKey(FileName.Settings, SectionName.AuthorizationData, 
                "SaltPass", "83");
            DeviceNumber = byte.Parse(iniManager.VerifyKey(FileName.Settings, SectionName.DataPicker, 
                "DeviceNumber", 0));
            DeviсeName = iniManager.VerifyKey(FileName.Settings, SectionName.DataPicker, 
                "DeviсeName", "Печь");
            ComPortName = iniManager.VerifyKey(FileName.Settings, SectionName.DataPicker, 
                "ComPortName", "COM1");
            BaudRate = int.Parse(iniManager.VerifyKey(FileName.Settings, SectionName.DataPicker, 
                "BaudRate", 19200));
            ArchiveFrequency = int.Parse(iniManager.VerifyKey(FileName.Settings, SectionName.DataPicker, 
                "ArchiveFrequency", 10));
        }

        public static void Save()
        {
            iniManager.Write(FileName.Settings, 
                SectionName.AuthorizationData, "SaltPass", SaltPass);
            iniManager.Write(FileName.Settings, 
                SectionName.DataPicker, "DeviceNumber", DeviceNumber.ToString());
            iniManager.Write(FileName.Settings, 
                SectionName.DataPicker, "DeviсeName", DeviсeName);
            iniManager.Write(FileName.Settings, 
                SectionName.DataPicker, "ComPortName", ComPortName);
            iniManager.Write(FileName.Settings, 
                SectionName.DataPicker, "BaudRate", BaudRate.ToString());
            iniManager.Write(FileName.Settings, 
                SectionName.DataPicker, "ArchiveFrequency", ArchiveFrequency.ToString());
        }
    }
}
