using System;
using System.Runtime.InteropServices;
using System.Text;

namespace iniManager {
	public static class ini {
		private static readonly string Path = Environment.CurrentDirectory + "//Miniterm.ini"; //Имя файла.

		[DllImport("kernel32")] // Подключаем kernel32.dll и описываем его функцию WritePrivateProfilesString
		private static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

		[DllImport("kernel32")] // Еще раз подключаем kernel32.dll, а теперь описываем функцию GetPrivateProfileString
		private static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

		//Читаем ini-файл и возвращаем значение указного ключа из заданной секции.
		private static string ReadKey(string section, string key) {
			var retVal = new StringBuilder(255);
			GetPrivateProfileString(section, key, "", retVal, 255, Path);
			return retVal.ToString();
		}

		//Записываем в ini-файл. Запись происходит в выбранную секцию в выбранный ключ.
		public static void Write(string section, string key, string value) {
			WritePrivateProfileString(section, key, value, Path);
		}

		//Проверяем, есть ли такой ключ, в этой секции
		public static string VerifyKey(string section, string key, object defaultKey) {
			string data = ReadKey(section, key);
			if (data.Length > 0)
				return ReadKey(section, key);
			Write(section, key, defaultKey.ToString());
			return defaultKey.ToString();
		}
	}
}
