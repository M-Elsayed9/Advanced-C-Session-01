using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Generics
{
    // equals with struct compares object state [data]\
    // equals with class compares object reference [identity] and not state [data]
    internal class Employee : IComparable<Employee>
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

        // sorting based on salary
        public int CompareTo(Employee? other)
        {
            // Employee? e = (Employee)other; // unsafe casting may throw an exception

            #region Is Conditional operator [true \false
            // if other is Employee
            // or other os an object from a class that inherits from Employee
            // no need to check for null because it is an object that implments the icomparable class

            //if (other is Employee e)
            //{
            //    return this.Salary.CompareTo(e.Salary);
            //}

            //return 1; 
            #endregion

            #region As Casting Operator

            if (ReferenceEquals(this, other))
                return 0;

            Employee? e = other as Employee;
            // casting succeeds in 2 cases
            // 1. other is Employee
            // 2. other is an object from a class that inherits from Employee
            // if failed e will be null
            // no exception will be thrown

            return this.Salary.CompareTo(e.Salary);
            #endregion
        }
    }
}
