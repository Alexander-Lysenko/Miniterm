using System;
using iniManager;

namespace UI_MiniTerm {
	internal static class SettingsDP {
		public static string SaltPass = "83";
		public static byte DeviceNumber = 0;
		public static string DeviсeName = "Печь";
		public static string ComPortName = "COM1";
		public static int BaudRate = 19200;
		public static int ArchiveFrequency = 10;

		public static void Save() {
			ini.Write(SectionName.Authorization, "SaltPass", SaltPass);
			ini.Write(SectionName.DataPicker, "DeviceNumber", DeviceNumber.ToString());
			ini.Write(SectionName.DataPicker, "DeviсeName", DeviсeName);
			ini.Write(SectionName.DataPicker, "ComPortName", ComPortName);
			ini.Write(SectionName.DataPicker, "BaudRate", BaudRate.ToString());
			ini.Write(SectionName.DataPicker, "ArchiveFrequency", ArchiveFrequency.ToString());
		}

		public static void Get() {
			SaltPass = ini.VerifyKey(SectionName.Authorization, "SaltPass", SaltPass);
			DeviceNumber = byte.Parse(ini.VerifyKey(SectionName.DataPicker, "DeviceNumber", DeviceNumber));
			DeviсeName = ini.VerifyKey(SectionName.DataPicker, "DeviсeName", DeviсeName);
			ComPortName = ini.VerifyKey(SectionName.DataPicker, "ComPortName", ComPortName);
			BaudRate = int.Parse(ini.VerifyKey(SectionName.DataPicker, "BaudRate", BaudRate));
			ArchiveFrequency = int.Parse(ini.VerifyKey(SectionName.DataPicker, "ArchiveFrequency", ArchiveFrequency));
		}
	}
}
