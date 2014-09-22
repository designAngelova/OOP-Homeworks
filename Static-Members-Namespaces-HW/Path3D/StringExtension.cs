using System.Linq;
using System.Text.RegularExpressions;

namespace Path3D
{
    public static class StringExtension
    {
        public static string[] GetPaths(this string text)
        {
            Regex regex = new Regex(@"\[X:\s([^,]+),\sY:\s([^,]+),\sZ:\s([^\]]+)\]");

            return regex.Matches(text).OfType<Match>()
                .Select(m => m.Value)
                .ToArray();
        }
    }
}
