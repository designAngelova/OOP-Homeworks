using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StringBuilderExtApp
{
    public static class StringBuilderExtension
    {
        public static string Substring(this StringBuilder sb, int start, int length)
        {
            if (start < 0 || start > sb.Length || length > sb.Length || start + length > sb.Length)
            {
                throw new IndexOutOfRangeException("Please enter an index from 0 to " + sb.Length);
            }

            StringBuilder newSb = new StringBuilder();

            for (int i = start; i < length + start; i++)
            {
                newSb.Append(sb[i]);
            }

            return newSb.ToString();
        }

        public static StringBuilder RemoveText(this StringBuilder sb, string text)
        {
            Regex regex = new Regex(text, RegexOptions.IgnoreCase | RegexOptions.Multiline);
            RegexOptions options = RegexOptions.None;
            Regex regex2 = new Regex(@"[ ]{2,}", options);

            return new StringBuilder(regex2.Replace(regex.Replace(sb.ToString(), String.Empty).Trim(), " "));
        }

        public static StringBuilder AppendAll<T>(this StringBuilder sb, IEnumerable<T> items)
        {
            StringBuilder newSb = new StringBuilder(sb.ToString());

            foreach (var item in items)
            {
                newSb.Append(item);
            }

            return newSb;
        }
    }
}
