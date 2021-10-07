using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    enum Gender
    {
        Male,
        Female
    }

    abstract class Person
    {
        public string Name { get; }
        public string ID { get; set; }
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


        public Person(string _Name, Gender _Gender, DateTime _Birthday)
        {
            Name = _Name;
            Gender = _Gender;
            Birthday = _Birthday;
        }
        public Person()
        {

        }

    }
}
