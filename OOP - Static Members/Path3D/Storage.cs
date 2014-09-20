namespace Path3D
{
    using System.IO;

    static class Storage
    {
        private const string Path = @"C:\sites\path.txt";

        public static void WriteToFile(string path)
        {
            File.WriteAllText(Path, path);
        }

        public static string ReadFromFile()
        {
            return File.ReadAllText(Path);
        }
    }
}
