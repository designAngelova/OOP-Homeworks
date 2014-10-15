using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringDispenserApp
{
    public class StringDispenser : IComparable<StringDispenser>, IEnumerable<char>, ICloneable
    {
        private StringBuilder stringHolder;

        public StringDispenser(params string[] words)
        {
            StringHolder = new StringBuilder();

            foreach (var word in words)
            {
                StringHolder.Append(word);
            }
        }

        public StringBuilder StringHolder { get; private set; }

        public override bool Equals(object obj)
        {
            StringDispenser other = obj as StringDispenser;

            if (other == null)
            {
                return false;
            }

            return this.StringHolder == other.StringHolder;
        }

        public override int GetHashCode()
        {
            IEnumerable<string> splittedStringHolder = Split(this.StringHolder.ToString(), 3);

            int hashCode = int.MinValue;

            foreach (var part in splittedStringHolder)
            {
                hashCode ^= part.GetHashCode();
            }

            return hashCode;
        }

        public static bool operator ==(StringDispenser sd1, StringDispenser sd2)
        {
            if (ReferenceEquals(sd1, sd2))
            {
                return true;
            }

            if (((object) sd1 == null) || ((object) sd2 == null))
            {
                return false;
            }

            return sd1.StringHolder == sd2.StringHolder;
        }

        public static bool operator !=(StringDispenser sd1, StringDispenser sd2)
        {
            return !(sd1 == sd2);
        }

        public int CompareTo(StringDispenser other)
        {
            return this.StringHolder.ToString().CompareTo(other.StringHolder.ToString());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<char> GetEnumerator()
        {
            foreach (var c in this.StringHolder.ToString())
            {
                yield return c;
            }
        }

        static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public StringDispenser Clone()
        {
            StringDispenser sdCopy = new StringDispenser();

            sdCopy.StringHolder.Append(this.StringHolder);

            return sdCopy;
        }
    }
}
