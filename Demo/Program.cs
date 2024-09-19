using Demo.Generics;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generics [Swap Ex]

            #region Non Generic way
            //int a = 10, b = 20;
            //Console.WriteLine($"Before Swap: a={a}, b={b}");
            //Helper.Swap(ref a, ref b);
            //Console.WriteLine($"After Swap: a={a}, b={b}");

            //double a = 10.5, b = 20.5;
            //Console.WriteLine($"Before Swap: a={a}, b={b}");
            //Helper.Swap(ref a, ref b);
            //Console.WriteLine($"After Swap: a={a}, b={b}");

            //Point p1 = new Point(10, 20);
            //Point p2 = new Point(30, 40);
            //Console.WriteLine($"Before Swap: p1={p1}, p2={p2}");
            //Helper.Swap(ref p1, ref p2);
            //Console.WriteLine($"After Swap: p1={p1}, p2={p2}");
            #endregion

            #region Generic Way
            //int a1 = 10, b1 = 20;
            //Console.WriteLine($"Before Swap: a={a1}, b={b1}");
            //Helper<int>.Swap(ref a1, ref b1);
            //Console.WriteLine($"After Swap: a={a1}, b={b1}");

            //double a = 10.5, b = 20.5;
            //Console.WriteLine($"Before Swap: a={a}, b={b}");
            //Helper<double>.Swap(ref a, ref b);
            //Console.WriteLine($"After Swap: a={a}, b={b}");

            //Point p1 = new Point(10, 20);
            //Point p2 = new Point(30, 40);
            //Console.WriteLine($"Before Swap: p1={p1}, p2={p2}");
            //Helper<Point>.Swap(ref p1, ref p2);
            //Console.WriteLine($"After Swap: p1={p1}, p2={p2}");

            #endregion

            #endregion

            #region Generics [Search Example] & equality & hashcode

            //int[] arr = { 10, 20, 30, 40, 50 };

            //int key = 30;

            //int index = Helper<int>.SearchArray(arr, key);

            //if (index != -1)
            //    Console.WriteLine($"Key {key} found at index {index}");
            //else
            //    Console.WriteLine($"Key {key} not found");

            //Employee E01 = new Employee { Id = 102, Name = "John", Salary = 10000 };
            //Employee E02 = new Employee { Id = 102, Name = "Smith", Salary = 20000 };

            //Console.WriteLine(E01 == E02); // reference comparison

            //Console.WriteLine(E01.Equals(E02)); // data comparison with struct type

            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());


            //Employee E03 = new Employee { Id = 101, Name = "John", Salary = 10000 };
            //if (E01 == E02)
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");

            //Employee[] employees =
            //{
            //    E01, E02
            //};

            //int index = Helper<Employee>.SearchArray(employees, E03);

            //if (index != -1)
            //    Console.WriteLine($"Employee found at index {index}");
            //else
            //    Console.WriteLine("Employee not found");

            //int x = 10;
            //Console.WriteLine(x.GetHashCode());
            #endregion

            #region Generics [Sorting example][Equality]
            //int[] Numbers = { 2, 5, 1, 9, 2, 3, 6, 7, 8 };

            //foreach (int n in Numbers)
            //    Console.Write($"{n} ");

            //Helper<int>.BubbleSort(Numbers);

            //Console.WriteLine("\nAfter Sorting");
            //foreach(int n in Numbers)
            //    Console.Write($"{n} ");

            //string[] Names = { "John", "Smith", "Peter", "David", "Alice" };

            //foreach (string n in Names)
            //    Console.Write($"{n} ");

            //Helper<string>.BubbleSort(Names);

            //Console.WriteLine("\nAfter Sorting");

            //foreach (string n in Names)
            //    Console.Write($"{n} ");

            //Employee[] employees = {
            //    new Employee { Id = 1011, Name = "John", Salary = 10000 },
            //    new Employee { Id = 102, Name = "Smith", Salary = 20000 },
            //    new Employee { Id = 103, Name = "Peter", Salary = 15000 },
            //    new Employee { Id = 104, Name = "David", Salary = 12000 },
            //    new Employee { Id = 105, Name = "Alice", Salary = 18000 }
            //};

            //foreach (Employee e in employees)
            //    Console.WriteLine(e);

            //Helper<Employee>.BubbleSort(employees);

            //Console.WriteLine("\nAfter Sorting");

            //foreach (Employee e in employees)
            //    Console.WriteLine(e);

            Point[] points = {
                new Point(10, 20),
                new Point(5, 15),
                new Point(30, 40),
                new Point(20, 10),
                new Point(15, 5)
            };

            foreach (Point p in points)
                Console.WriteLine(p);

            Helper<Point>.BubbleSort(points);

            Console.WriteLine("\nAfter Sorting");
            #endregion

            #region Generics Constraints


            #endregion
        }
    }
}
