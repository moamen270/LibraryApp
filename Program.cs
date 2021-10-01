using System;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Author a1 = new Author("moamen", 451451, "asdd", DateTime.Now, Gender.Male);
            Libarian L1 = new Libarian("kaas", Gender.Male, DateTime.Now, 5125, "asdd", 4851);
            Member m1 = new Member("moamen", 451451, "asdd", DateTime.Now, Gender.Male);
            Book b1 = new Book("elesm", a1, "ay7aga", 5);
            L1.Borrow(m1, b1);
            Libarian.AllBorrowCards();
            m1.GetBookCard();
            b1.GetMemberCard();

        }
    }
}
