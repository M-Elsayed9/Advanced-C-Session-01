using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Collections;
using System.Xml.Linq;
using System;

namespace Assignment
{
    internal class Program
    {
        public static void BubbleSort<T>(T[] arr) where T : IComparable<T>
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
        static void Main(string[] args)
        {
            //            Assignment

            #region Question 01
            //1. The Bubble Sort algorithm has a time complexity of
            //O(n ^ 2) in its worst and average cases, which makes
            //it inefficient for large datasets. How we can
            //optimise the Bubble Sort algorithm
            //And implement the code of this optimised bubble sort algorithm 

            //Optimised Bubble Sort Algorithm:
            //The optimised Bubble Sort algorithm is a variation of the Bubble Sort algorithm that
            //stops early if the inner loop didn't cause any swap, which means the array is already
            //sorted. This optimisation reduces the time complexity of the Bubble Sort algorithm
            //from O(n^2) to O(n) in the best-case scenario when the array is already sorted.
            //The optimised Bubble Sort algorithm is implemented as follows:

            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            int n = arr.Length;

            Console.WriteLine("Original array: ");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }

            BubbleSort(arr);

            Console.WriteLine("Sorted array: ");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            #endregion

            #region Question 02
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

            #endregion

            #region Question 03
            //3. You are given an ArrayList containing a sequence \
            //of elements. try to reverse the order of elements in
            //the ArrayList in-place(in the same arrayList) without
            //using the built-in Reverse.Implement a function that
            //takes the ArrayList as input and modifies it to have
            //the reversed order of elements.

            #endregion

            #region Question 04
            //4.You are given a list of integers.Your task is to find and return a new list containing only the even numbers from the given list.

            #endregion

            #region Question 05

            //5. implement a custom list called FixedSizeList<T>
            //with a predetermined capacity.This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
            //Requirements:

            //1. Create a generic class named FixedSizeList<T>.

            //2. Implement a constructor that takes the fixed capacity
            //of the list as a parameter.

            //3. Implement an Add method that adds an element to
            //the list, but throws an exception if the list is
            //already full.

            //4. Implement a Get method that retrieves an element
            //at a specific index in the list but throws an
            //exception for invalid indices.

            #endregion

            #region Question 06
            //Given a string, find the first non - repeated
            //character in it and return its index.If there is no
            //such character, return -1.Hint you can use dictionary

            #endregion

        }
    }
}
