using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    class Member : Person
    {
        public static int NumberOfMembers
        {
            get
            {
                return SerialNumber - 67412785;
            }
        }
        private List<BookCard> BookCards { get; }
        public int NumberOfBorrowedBooks = 0;
        private static int SerialNumber = 67412785;

        public Member(string Name , int Phone ,string Address, DateTime Birthday,Gender gender)
            :base(SerialNumber,Name,Phone,Address,Birthday,gender)
        {
            BookCards = new List<BookCard>();
            SerialNumber++;
        }                 
        public void SetBookCards(BookCard BookCard)
        {
            BookCards.Add(BookCard);
        }
        public void GetBookCard()
        {
            if(NumberOfBorrowedBooks>0)
            foreach (var item in BookCards)
            {
                Console.WriteLine(item);
            }
            else
                Console.WriteLine("This members did not borrow any book");
        }
        public override string ToString()
        {
            return $" Name : {Name}\n ID: {ID}\n Phone: {Phone} Address: {Address}";
        }
    }
}
