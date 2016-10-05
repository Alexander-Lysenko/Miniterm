namespace FileManager {
    public interface IFileManagerWrite {
        void Close();
        void Write(string s);
    }
}