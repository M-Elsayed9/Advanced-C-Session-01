using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    //5. implement a custom list called FixedSizeList<T>
    //with a predetermined capacity.This list should not allow more elements
    //than its capacity and should provide clear messages if one
    //tries to exceed it or access invalid indices.
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
    public class FixedSizeList<T>
    {
        private T[] _items; 
        public int Count { get; private set; } 

        public int Capacity { get; private set; } 

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero.");

            Capacity = capacity;
            _items = new T[capacity];
            Count = 0;
        }

        public void Add(T item)
        {
            if (Count >= Capacity)
            {
                throw new InvalidOperationException("The list is full. Cannot add more elements.");
            }

            _items[Count] = item;
            Count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Invalid index. Please provide a valid index within range.");
            }

            return _items[index];
        }

        // Indexer to allow access using the square brackets [] syntax
        public T this[int index]
        {
            get { return Get(index); }
        }

       
    }
}
