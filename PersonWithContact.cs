using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    abstract class PersonWithContact : Person
    {
        public string Phone { get; }
        public string Email { get; }

        public PersonWithContact(string _Name, int SerialNumber, string _Phone, string _Email, Gender _Gender, DateTime _Birthday)
            : base(_Name, SerialNumber, _Gender, _Birthday)
        {
            this.Phone = _Phone;
            this.Email = _Email;
        }
    }
}
