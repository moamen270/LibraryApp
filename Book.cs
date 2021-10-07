using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    class Book 
    {
        #region Attrebuts
        #region Object Attrebuts
        public string Name { get; }
        public string ID { get; }
        public Author Author { get; }
        public string Type { get; }
        public int NumberOfBooks { get; }
        public int NumberOfBorrowedBooks { get => MemberCards.Count; }
        public int NumberOfAvailableBooks { get => NumberOfBooks - NumberOfBorrowedBooks; }
        private List<OneSideCard<Member>> MemberCards { get; }
        #endregion
        #region Static Attrebuts
        private static List<OneSideCard<Member>> StaticMemberCards = new List<OneSideCard<Member>>();
        private static int StaticNumberOfBorrowedBooks { get => StaticMemberCards.Count; }
        private static List<Book> books = new List<Book>();
        private static int Serial = 20000;

        #endregion
        #endregion

        #region Constructor
        public Book(string Name, Author Author, string Type, int NumberOfBooks)
        {
            this.Name = Name;
            this.Author = Author;
            this.Type = Type;
            this.NumberOfBooks = NumberOfBooks;
            ID = $"B-{++Serial}";
            MemberCards = new List<OneSideCard<Member>>();
            books.Add(this);
        }
        #endregion

        #region Methods
        public void SetCard(OneSideCard<Member> MemberCard)
        {
            MemberCards.Add(MemberCard);
            StaticMemberCards.Add(MemberCard);           
        }

        public void GetCards()
        {
            Libarian.PrintCards(NumberOfBorrowedBooks, MemberCards);
        }
        public bool IsBorrowedAny()
        {
            if (NumberOfBorrowedBooks == 0) return false;
            return true;

        }
        #endregion

        #region Static Methods

        
        public static void AllMemberCards()
        {
            Libarian.PrintCards(StaticNumberOfBorrowedBooks, StaticMemberCards);           
        }
        #endregion

        #region Override Methods
        public override string ToString()
        {
            return $" Name : {Name}\n ID: {ID}\n Author: {Author} Type: {Type}";
        }
        #endregion
    }
}
