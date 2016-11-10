using System;
using System.IO;

namespace FileManager {
    public class FileManagerWrite : IFileManagerWrite {

        public StreamWriter File;

        public FileManagerWrite() {

            FileStream fileStream = new FileStream(CreateFolder.Path() + DateTime.Now.ToString("dd.MM.yyyy") + ".csv",
                FileMode.Append, FileAccess.Write, FileShare.Read);

            File = new StreamWriter(fileStream);
        }

        public void Write(string s) {
            File.WriteLine(s);
        }

        public void Close() {
            File.Close();
        }
    }
}
