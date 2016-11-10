using System;
using System.IO;

namespace FileManager {
    public class FileManagerRead : IFileManagerRead {

        public StreamReader File;

        public FileManagerRead() {

            FileStream fileStream = new FileStream(CreateFolder.Path() + DateTime.Now.ToString("dd.MM.yyyy") + ".csv",
                FileMode.OpenOrCreate, FileAccess.Read, FileShare.Write);

            File = new StreamReader(fileStream);
        }

        public string Read() {
            return File.ReadLine();
        }

        public void Close() {
            File.Close();
        }
    }
}
