using System;
using System.Windows.Forms;
using ComManager;
using FileManager;
using SettingsManager;

namespace UI_DataPicker {
    static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(new ComPort(), new FileManagerWrite()));
        }
    }
}
