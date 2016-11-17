using SettingsManager;

namespace ComManager
{
    internal static class Protocol
    {
        public static ushort CurrentTemperature;    //Регулируемая температура
        public static ushort TaskTemperature;       //Задание
        public static ushort TXC;                   //Т.Х.С.
        public static ushort Mode;             //Текущий режим прибора

        static Protocol()
        {
            CurrentTemperature = ushort.Parse(iniManager.VerifyKey(FileName.Protocol, 
                SectionName.MinitermProtocol, "CurrentTemperature", (ushort)0x10DA));
            TaskTemperature = ushort.Parse(iniManager.VerifyKey(FileName.Protocol,
                SectionName.MinitermProtocol, "TaskTemperature", (ushort)0x1018));
            TXC = ushort.Parse(iniManager.VerifyKey(FileName.Protocol,
                SectionName.MinitermProtocol, "TXC", (ushort)0x112E));
            Mode = ushort.Parse(iniManager.VerifyKey(FileName.Protocol,
                SectionName.MinitermProtocol, "Mode", (ushort)0x101C));
        }
    }
}
