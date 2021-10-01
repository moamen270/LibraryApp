using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    class OneSideCard<Type>:Card
    {        
        private Member Member;
        private Book Book;        
        private static int NumberOfMemberCards=0;
        public static OneSideCard<Member> test = new OneSideCard<Member>(m1);
        public static Member m1 = new Member("maomen", 44545151, "adssad", DateTime.Now, Gender.Male);


        public OneSideCard(Book book) : base(false)
        {
           
            Book = book;
            BorrowDate = DateTime.Now;
        }
        public OneSideCard(Member member):base(false)
        {
            Member = member;
            BorrowDate = DateTime.Now;
            NumberOfMemberCards++;
        }
        public override string ToString()
        {
            StringBuilder BorrowCard = new StringBuilder();
            BorrowCard.AppendLine($"Borrow Date: {BorrowDate.ToShortDateString()}\tReturn Date: {ReturnDate}");
            if (this.GetType().ToString() == "LibraryApp.OneSideCard`1[LibraryApp.Member]")
            {
                BorrowCard.AppendLine($"Member Name: {Member.Name}\tMember ID: {Member.ID}");
                BorrowCard.AppendLine($"Serial Number: {CardID}");
                return BorrowCard.ToString();
            }
            else
            {
                BorrowCard.AppendLine($"Book Name: {Book.Name}\tBook ID: {Book.ID}");
                BorrowCard.AppendLine($"Serial Number: {CardID}");
                return BorrowCard.ToString();
            }

        }
        public string ToString(bool Borrow)
        {
            if (this.GetType().ToString() == "LibraryApp.OneSideCard`1[LibraryApp.Member]")
            {
                return $"Member Name: {Member.Name}\tMember ID: {Member.ID}";
            }
            else
            {
                return $"Book Name: {Book.Name}\tBook ID: {Book.ID}";
            }

        }

    }
}
