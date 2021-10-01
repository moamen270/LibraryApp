using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    abstract class Employee : Person
    {
        private static int SerialNumber = 95671020;
        public int NumberOfBorrowBooks = 0;
        public double Salary { get; }

        public static int NumberOfMembers
        {
            get
            {
                return SerialNumber - 95671020;
            }
        }
        public Employee(string Name, Gender gender, DateTime Birthday, int Phone, string Address,double Salary)
            : base(SerialNumber, Name, Phone, Address, Birthday, gender)
        {
            this.Salary = Salary;
            SerialNumber++;
        }
    }
}
