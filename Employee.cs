using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    abstract class Employee : PersonWithContact
    {
        public double Salary { get; }
       
        public Employee(string _Name, Gender _Gender, string _Phone, string _Email,string _Password, DateTime _Birthday, double _Salary)
            : base(_Name, _Phone, _Email,_Password, _Gender, _Birthday)
        {
            this.Salary = Salary;            
        }
    }
}
