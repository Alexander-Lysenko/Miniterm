using System;
using System.IO;

namespace FileManager
{
    public static class LogiManager
    {
        public static void Log(string message)
        {
            File.AppendAllText("log.txt",
                string.Format("[{0}] {1}{2}", DateTime.Now, message, Environment.NewLine));
        }
    }
}