using System;
using System.IO;

namespace FileManager {
    internal class CreateFolder {
        internal static string Path() {
            string path = Environment.CurrentDirectory + "\\Indications\\";
            //string path = @"C:\Users\cw\Documents\данные\";

            if (Directory.Exists(path) == false)
                Directory.CreateDirectory(path);
            return path;
        }
    }
}
