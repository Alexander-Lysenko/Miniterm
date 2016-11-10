namespace SettingsManager {
	public static class SettingsDp {
		public static string SaltPass = "83";
		public static byte DeviceNumber = 0;
		public static string DeviсeName = "Печь";
		public static string ComPortName = "COM1";
		public static int BaudRate = 19200;
		public static int ArchiveFrequency = 10;

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
