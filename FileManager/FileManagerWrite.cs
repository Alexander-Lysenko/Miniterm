using System;
using System.IO;

namespace FileManager {
    public class FileManagerWrite : IFileManagerWrite {

        public StreamWriter _file;

        public FileManagerWrite() {

            FileStream fileStream = new FileStream(CreateFolder.Path() + DateTime.Now.ToString("dd.MM.yyyy") + ".csv",
                FileMode.Append, FileAccess.Write, FileShare.Read);

            _file = new StreamWriter(fileStream);
        }

        public void Write(string s) {
            _file.WriteLine(s);
        }

        public void Close() {
            _file.Close();
        }
    }
}
