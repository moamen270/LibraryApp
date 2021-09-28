using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{   
    class Book
    {
        public string Name { get; }
        public int ID { get; }
        public Author Author { get; }
        public string Type { get; }
        public int NumberOfBooks { get; }
        public int NumberOfBorrowedBooks = 0;
        public int NumberOfAvailableBooks
        {
            get
            {
                return NumberOfBooks - NumberOfAvailableBooks;
            }
        }
        private List<MemberCard> MemberCards = new List<MemberCard>();
        static private int Serial = 5151215;

        public Book(string Name, Author Author, string Type, int NumberOfBooks)
        {
            this.Name = Name;
            this.Author = Author;
            this.Type = Type;
            this.NumberOfBooks = NumberOfBooks;
            ID = ++Serial;
        }
        public void SetMemberCards(MemberCard MemberCard)
        {
            MemberCards.Add(MemberCard);
        }
        public void GetMemberCard()
        {
            if(NumberOfBorrowedBooks>0)
            foreach (var item in MemberCards)
            {
                Console.WriteLine(item);
            }
            else
                Console.WriteLine("This Book has not been borrowed");
        }
        public override string ToString()
        {                                    
            return $" Name : {Name}\n ID: {ID}\n Author: {Author} Type: {Type}";
        }        
    }
}
