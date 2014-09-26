using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomLINQExtension
{
    public static class LinqExtension
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return collection.Where(x => predicate(x) == false);
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            return Enumerable.Repeat(collection, Int32.MaxValue)
                .SelectMany(strArray => strArray)
                .Take(collection.Count() * count)
                .ToList();
        } 

        public static IEnumerable<string>
            WhereEndsWith<T>(this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            var items = collection.Where(x =>
            {
                foreach (var suffix in suffixes)
                {
                    var a = x.Length;
                    var b = x.LastIndexOf(suffix);
                    if (x.Length - x.LastIndexOf(suffix) == suffix.Length)
                    {
                        return true;
                    }
                }

                return false;
            });

            return items;
        }
    }
}
