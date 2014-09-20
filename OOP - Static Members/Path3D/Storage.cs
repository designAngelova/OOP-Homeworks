using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path3D
{
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
