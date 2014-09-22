using System.Collections.Generic;
using System.IO;

namespace Path3D
{
    public static class Storage
    {
        public const string Path = @"..\..\paths.txt";

        public static void WriteToFile<T>(IEnumerable<T> objects)
        {
            foreach (var obj in objects)
            {
                File.AppendAllText(Path, obj.ToString());
            }
        }

        public static string ReadFromFile()
        {
            return File.ReadAllText(Path);
        }
    }
}
