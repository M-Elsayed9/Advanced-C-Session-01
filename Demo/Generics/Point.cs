using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Generics
{
    internal class Point : IComparable<Point>
    {

        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public int CompareTo(Point? other)
        {
            if (other is null)
                return 1;

            if (other is Point p)
            {
                if(this.X == p.X)
                    return this.Y.CompareTo(p.Y);
                else
                    return this.X.CompareTo(p.X);
            }

            return 1;
        }

       
    }
}
