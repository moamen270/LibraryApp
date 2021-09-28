using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    enum Gender { Male, Female }
    abstract class Person
    {
        public string Name { get; }
        public int ID { get; }
        public int Phone { get; }
        public string Address { get; }
        public Gender Gender { get; }
        public DateTime Birthday { get; }
        public int Age
        {
            get
            {
                int _Age = DateTime.Now.Year - Birthday.Year;
                if (DateTime.Now.Month < Birthday.Month) _Age++;
                else
                if (DateTime.Now.Month == Birthday.Month)
                    if (DateTime.Now.Day <= Birthday.Day) _Age++;
                return _Age;
            }
        }
        public Person(int SerialNumber, string _Name, int _Phone, string _Address, DateTime _Birthday, Gender _Gender)
        {
            this.Name = _Name;
            this.Phone = _Phone;
            this.Address = _Address;
            this.Birthday = _Birthday;
            this.Gender = _Gender;
            ID = SerialNumber;
        }
        
    }
}
