using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace _03StringDisperser
{
    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable<char>
    {
        //Fields
        private string combinedStrings;

        //Constructor
        public StringDisperser(params string[] strings)
        {
            this.CombineStrings(strings);
        }

        //Add to field method with validation
        private void CombineStrings(string[] strings)
        {
            StringBuilder combined = new StringBuilder();
            foreach (var str in strings)
            {
                combined.Append(str);
            }
            this.combinedStrings = combined.ToString();
        }

        //a public property to show the value if needed
        public string Value
        {
            get
            {
                return this.combinedStrings;
            }
        }

        //Enumerator
        public IEnumerator<char> GetEnumerator()
        {
            int index = 0;
            while (index < this.combinedStrings.Length)
            {
                char thisElement = this.combinedStrings[index];
                yield return thisElement;
                index++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //Compare method
        public int CompareTo(StringDisperser other)
        {
            int result = this.combinedStrings.CompareTo(other.combinedStrings);
            return result;
        }

        //ToString override
        public override string ToString()
        {
            return this.combinedStrings;
        }

        //GetHashCode override
        public override int GetHashCode()
        {
            return this.combinedStrings.GetHashCode();
        }

        //Clone Method
        public object Clone()
        {
            return new StringDisperser(this.combinedStrings);
        }

        //Equals override
        public override bool Equals(object obj)
        {
            if (Object.Equals(this, null) || Object.Equals(obj, null) || obj is StringDisperser == false)
            {
                return false;
            }
            var other = obj as StringDisperser;
            return this.combinedStrings.Equals(other.combinedStrings);
        }

        //Equals operator
        public static bool operator ==(StringDisperser disperserA, StringDisperser disperserB)
        {
            if (Object.Equals(disperserA, null) || Object.Equals(disperserB, null))
            {
                return false;
            }
            return disperserA.Equals(disperserB);
        }

        //Does Not equal operator
        public static bool operator !=(StringDisperser disperserA, StringDisperser disperserB)
        {
            if (Object.Equals(disperserA, null) || Object.Equals(disperserB, null))
            {
                return false;
            }
            return !disperserA.Equals(disperserB);
        }

    }
}
