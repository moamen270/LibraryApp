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
            : base(_Name, _Gender, _Birthday)
        {
            Books = new List<Book>();
            ID = $"A-{SerialNumber++}";
        }

        public void SetBook(Book book)
        {
            Books.Add(book);
        }

        public void GetBooks()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
