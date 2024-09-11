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
            int a1 = 10, b1 = 20;
            Console.WriteLine($"Before Swap: a={a1}, b={b1}");
            Helper<int>.Swap(ref a1, ref b1);
            Console.WriteLine($"After Swap: a={a1}, b={b1}");

            double a = 10.5, b = 20.5;
            Console.WriteLine($"Before Swap: a={a}, b={b}");
            Helper<double>.Swap(ref a, ref b);
            Console.WriteLine($"After Swap: a={a}, b={b}");

            Point p1 = new Point(10, 20);
            Point p2 = new Point(30, 40);
            Console.WriteLine($"Before Swap: p1={p1}, p2={p2}");
            Helper<Point>.Swap(ref p1, ref p2);
            Console.WriteLine($"After Swap: p1={p1}, p2={p2}");

            #endregion

            #endregion
        }
    }
}
