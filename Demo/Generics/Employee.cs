using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Generics
{
    internal struct Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
        }

        public static bool operator ==(Employee e1, Employee e2)
        {
            //return e1.Id == e2.Id && e1.Name == e2.Name && e1.Salary == e2.Salary;
            return e1.Equals(e2);

        }

        public static bool operator !=(Employee e1, Employee e2)
        {
            
            return !e1.Equals(e2);
            //return e1.Id != e2.Id || e1.Name != e2.Name || e1.Salary != e2.Salary;
        }

         
    }
}
