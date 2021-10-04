using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    class Libarian : Employee
    {
        private static int SerialNumber = 844555656;
        private static List<BorrowCard> BorrowCards = new List<BorrowCard>();
        private static int NumberOfBorrowCards = 0;

        public Libarian(string Name, string Phone, string Email, Gender gender, DateTime Birthday, double Salary)
           : base(Name, gender, Phone, Email, Birthday, Salary)
        {
            SerialNumber++;
        }

        public void Borrow(Member member, Book book)
        {
            if (book.NumberOfAvailableBooks > 0)
            {
                BorrowCard borrowCard = new BorrowCard(member, book, this);
                BorrowCards.Add(borrowCard);
            }
            else
                Console.WriteLine("Not Available");
        }

        public static void AllBorrowCards()
        {
            if (NumberOfBorrowCards > 0)
                foreach (var item in BorrowCards)
                {
                    Console.WriteLine(item);
                }
            else
                Console.WriteLine("Empty");
        }
        public override string ToString()
        {
            return $"Libarian Name : {Name}\tLibarian ID: {ID}";
        }

        private class BorrowCard : Card
        {
            public Libarian Libarian;
            public OneSideCard<Member> MemberCard;
            public OneSideCard<Book> BookCard;

            public BorrowCard(Member _Member, Book _Book, Libarian _Libarian) : base(true)
            {
                BorrowDate = DateTime.Now;
                OneSideCard<Member> memberCard = new OneSideCard<Member>(_Member);
                OneSideCard<Book> bookCard = new OneSideCard<Book>(_Book);
                Libarian = _Libarian;
                MemberCard = memberCard;
                BookCard = bookCard;
                _Member.SetBookCards(bookCard);
                _Member.NumberOfBorrowedBooks++;
                _Book.SetMemberCards(memberCard);
                _Book.NumberOfBorrowedBooks++;
                NumberOfBorrowCards++;
            }

            public override string ToString()
            {
                StringBuilder BorrowCard = new StringBuilder();

                BorrowCard.AppendLine($"Borrow Date: {BorrowDate.ToShortDateString()}\tReturn Date: {ReturnDate}");
                BorrowCard.AppendLine(MemberCard.PrintIn());
                BorrowCard.AppendLine(BookCard.PrintIn());
                BorrowCard.AppendLine(Libarian.ToString());
                BorrowCard.AppendLine($"Card Serial: {CardID}");

                return BorrowCard.ToString();
            }

        }

    }
}
