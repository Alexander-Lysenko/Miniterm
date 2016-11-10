using System;
using System.IO;

namespace FileManager {
    internal class CreateFolder {
        internal static string Path() {
            string path = Environment.CurrentDirectory + "\\Indications\\";
            if (Directory.Exists(path) == false)
                Directory.CreateDirectory(path);
            return path;
        }
    }
}
