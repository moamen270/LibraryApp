using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    class Member : PersonWithContact
    {
        public static int NumberOfMembers
        {
            get
            {
                return SerialNumber - 67412785;
            }
        }
        private List<OneSideCard<Book>> BookCards { get; }
        public int NumberOfBorrowedBooks = 0;
        private static int SerialNumber = 67412785;

        public Member(string _Name, string _Phone, string _Email, Gender _Gender, DateTime _Birthday)
            : base(_Name, SerialNumber, _Phone, _Email, _Gender, _Birthday)
        {
            BookCards = new List<OneSideCard<Book>>();
            SerialNumber++;
        }
        public void SetBookCards(OneSideCard<Book> BookCard)
        {
            BookCards.Add(BookCard);
        }
        public void GetBookCard()
        {
            if (NumberOfBorrowedBooks > 0)
                foreach (var item in BookCards)
                {
                    Console.WriteLine(item);
                }
            else
                Console.WriteLine("This members did not borrow any book");
        }
        public override string ToString()
        {
            return $" Name : {Name}\n ID: {ID}\n Phone: {Phone}  Email: {Email}";
        }
    }
}
