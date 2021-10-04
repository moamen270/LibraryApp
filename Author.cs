using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    class Author : Person
    {
        private List<Book> Books { get; }
        private static int SerialNumber = 21568686;

        public Author(string _Name, Gender _Gender, DateTime _Birthday)
            : base(_Name, SerialNumber, _Gender, _Birthday)
        {
            Books = new List<Book>();
            SerialNumber++;
        }

        public void SetBook(Book book)
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
