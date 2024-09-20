using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    //2. create a generic Range < T > class that
    //represents a range of values from a minimum
    //value to a maximum value.The range should
    //support basic operations such as checking
    //if a value is within the range and determining
    //the length of the range.
    //Requirements:

    //1. Create a generic class named Range<T> where
    //T represents the type of values.

    //2. Implement a constructor that takes the minimum
    //and maximum values to define the range.

    //3. Implement a method IsInRange(T value) that returns
    //true if the given  value is within the range,
    //otherwise false.

    //4. Implement a method Length() that returns the length
    //of the range (the difference between the maximum and
    //minimum values).

    //5. Note: You can assume that the type T used in the
    //Range<T> class implements the IComparable<T> interface to allow for comparisons.
    internal class Range<T> where T : notnull, IComparable<T>
    {

        public T Min { get; set; }

        public T Max { get; set; }

        public Range(T min, T max)
        {
            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        {
            if (value is null)
            {
                return false;
            }

            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public T Length()
        {
            return (dynamic)Max - (dynamic)Min;
        }

        public override string ToString() {
            return $"Min: {Min}, Max: {Max}";
        }

        public int CompareTo(Range<T> other)
        {
            if (other == null) return 1; // If the other range is null, this one is considered greater.

            // Compare the minimum values first.
            int minComparison = this.Min.CompareTo(other.Min);
            if (minComparison != 0)
                return minComparison;

            // If the minimum values are the same, compare the maximum values.
            return this.Max.CompareTo(other.Max);
        }
    }
}
