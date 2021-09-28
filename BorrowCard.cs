using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    class BorrowCard:Card
    {
        public MemberCard MemberCard;
        public BookCard BookCard;
        private static List<BorrowCard> BorrowCards = new List<BorrowCard>();
        private static int NumberOfBorrowCards = 0;

        private BorrowCard(Member _Member, Book _Book):base(true)
        {
            BorrowDate = DateTime.Now;
            MemberCard memberCard = new MemberCard(_Member);
            BookCard bookCard = new BookCard(_Book);
            MemberCard = memberCard;
            BookCard = bookCard;
            _Member.SetBookCards(bookCard);
            _Member.NumberOfBorrowedBooks++;
            _Book.SetMemberCards(memberCard);            
            _Book.NumberOfBorrowedBooks++;
            NumberOfBorrowCards++;
        }
        public static void Borrow(Member member,Book book)
        {
            if (book.NumberOfAvailableBooks > 0)
            {
                BorrowCard borrowCard = new BorrowCard(member, book);
                BorrowCards.Add(borrowCard);
                
            }
            else
                Console.WriteLine("Not Available");
        }
        public static void AllBorrowCards()
        {
            if(NumberOfBorrowCards >0)
            foreach (var item in BorrowCards)
            {
                Console.WriteLine(item);
            }
            else
                Console.WriteLine("Empty");
        }
        public override string ToString()
        {
            StringBuilder BorrowCard = new StringBuilder();
            BorrowCard.AppendLine($"Borrow Date: {BorrowDate.ToShortDateString()}\tReturn Date: {ReturnDate}");
            BorrowCard.AppendLine($"Member Name: {MemberCard.Member.Name}\tMember ID: {MemberCard.Member.ID}");
            BorrowCard.AppendLine($"Book Name: {BookCard.Book.Name}\tBook ID: {BookCard.Book.Name}");
            BorrowCard.AppendLine($"Serial Number: {CardID}");
            return BorrowCard.ToString();
        }

    }
}
