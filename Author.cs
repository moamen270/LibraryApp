using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    class Author : Person
    {
        private List<Book> Books { get; }
        private static int SerialNumber = 21568686;
        public Author(string Name, int Phone, string Address, DateTime Birthday, Gender gender)
            :base(SerialNumber, Name, Phone, Address, Birthday, gender)
        {
            Books = new List<Book>();
            SerialNumber++;
        }
        public void SetBooks(Book book)
        {
            Books.Add(book);
        }
        public void GetBooks()
        {
            foreach (var item in Books)
            {
                Console.WriteLine(item);
            }
        }
    }
}
