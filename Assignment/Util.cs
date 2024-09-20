using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Util<T> where T : IComparable<T>
    {
        public static void BubbleSort(T[] arr)
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

        public static void ReverseArrayList(ArrayList arrayList)
        {
            if (arrayList == null || arrayList.Count == 0)
                throw new ArgumentException("ArrayList is null or empty.");

            int start = 0;
            int end = arrayList.Count - 1;

            while (start < end)
            {
                object? temp = arrayList[start];
                arrayList[start] = arrayList[end];
                arrayList[end] = temp;

                start++;
                end--;
            }
        }
    }
}
