using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    class BookCard :Card
    {
        public Book Book;
       
        public BookCard(Book book):base(false)
        {       
            Book = book;
            BorrowDate = DateTime.Now;
        }
        public override string ToString()
        {
            StringBuilder BookCard = new StringBuilder();
            BookCard.AppendLine($"Borrow Date: {BorrowDate.ToShortDateString()}\tReturn Date: {ReturnDate}");
            BookCard.AppendLine($"Book Name: {Book.Name}\tBook ID: {Book.Name}");
            BookCard.AppendLine($"Serial Number: {CardID}");
            return BookCard.ToString();
        }

    }
}
