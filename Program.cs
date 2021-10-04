using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Author a1 = new Author("moamen", Gender.Male, DateTime.Now);
            Libarian L1 = new Libarian("kaas", "5125", "asdd", Gender.Male, DateTime.Now, 4851);
            Member m1 = new Member("moamen", "451451", "asdd", Gender.Male, DateTime.Now);
            Book b1 = new Book("elesm", a1, "ay7aga", 5);
            L1.Borrow(m1, b1);
            Libarian.AllBorrowCards();
            m1.GetBookCard();
            b1.GetMemberCard();
        }
    }
}
