using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Generics
{
    // equals with struct compares object state [data]\
    // equals with class compares object reference [identity] and not state [data]
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
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

        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   this.Id == employee?.Id &&
                   this.Name == employee?.Name &&
                   this.Salary == employee?.Salary;
        }

        public override int GetHashCode()
        {
            // return this.id.GetHashCode() + this.name.GetHashCode() + this.salary.GetHashCode();
            return HashCode.Combine(Id.GetHashCode(), Name.GetHashCode(), Salary.GetHashCode());
        }
    }
}
