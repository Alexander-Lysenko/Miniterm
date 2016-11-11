using System;
using System.IO;

namespace FileManager {
    public class FileManagerRead : IFileManagerRead {

        private readonly StreamReader _file;

        public FileManagerRead() {

            FileStream fileStream = new FileStream(CreateFolder.Path() + DateTime.Now.ToString("dd.MM.yyyy") + ".csv",
                FileMode.OpenOrCreate, FileAccess.Read, FileShare.Write);

            _file = new StreamReader(fileStream);
        }

        public string Read() {
            return _file.ReadLine();
        }

        public void Close() {
            _file.Close();
        }
    }
}
