using Demo.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Helper<T>
    {
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
        #endregion

        #region Generics

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }


        #endregion

    }
}
