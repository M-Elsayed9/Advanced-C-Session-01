using Demo.Generics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Helper<T> where T : notnull, IComparable<T>
    {

        // T must be class or struct that implments the IComparable interface
        // IComparable interface has CompareTo method that returns int
        // In case generic type <T> is declared on method level not class Or Struct Or Interface
        // Compiler can detect the type of T based of Passed Parameters

        #region non Generic
        //public static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}

        //public static void Swap(ref double a, ref double b)
        //{
        //    double temp = a;
        //    a = b;
        //    b = temp;
        //}

        //public static void Swap(ref Point a, ref Point b)
        //{
        //    Point temp = a;
        //    a = b;
        //    b = temp;
        //} 

        //public static void BubbleSort(int[] arr)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length - 1; i++)
        //        {
        //            for (int j = 0; j < arr.Length - i - 1; j++)
        //            {
        //                if (arr[j] > arr[j + 1])
        //                {
        //                    Helper.Swap(ref arr[j], ref arr[j + 1]);
        //                }
        //            }
        //        }
        //    }
        //}
        #endregion

        #region Generics

        public static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static int SearchArray(T[] arr, T key)
        {
            if(arr is not null) {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(key))
                        return i;
                }
            }
            return -1;
        }

        public static void BubbleSort<T1>(T1[] arr) where T1 : IComparable<T1>
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) == 1)

                            Helper<T1>.Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        public static T Sum(T a, T b)
        {
            // return a + b; // Error: Operator '+' cannot be applied to operands of type 'T' and 'T'
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }
        #endregion

    }
}
