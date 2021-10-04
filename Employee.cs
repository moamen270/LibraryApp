using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    abstract class Employee : PersonWithContact
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
        public Employee(string _Name, Gender _Gender, string _Phone, string _Email, DateTime _Birthday, double _Salary)
            : base(_Name, SerialNumber, _Phone, _Email, _Gender, _Birthday)
        {
            this.Salary = Salary;
            SerialNumber++;
        }
    }
}
