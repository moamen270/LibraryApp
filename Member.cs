using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryApp
{
    class Member : PersonWithContact
    {
        // Attributs 

        #region Attributs

        #region Object Attributs
        public int sSerialNumber ;
        private List<OneSideCard<Book>> BookCards { get; }
        public int NumberOfBorrowedBooks { get => BookCards.Count; }
        #endregion

        #region Class Attributs
        private static List<OneSideCard<Book>> StaticBookCards = new List<OneSideCard<Book>>();
        public static List<Member> Members = new List<Member>(); // Store All members objects in list
        private static int StaticNumberOfBorrowedBooks { get => StaticBookCards.Count; }
        private static int SerialNumber = 1000;
        #endregion

        #endregion

        #region Constructors

        //with Parameters
        public Member(string _Name, string _Phone, string _Email, string _Password, Gender _Gender, DateTime _Birthday)
            : base(_Name, _Phone, _Email, _Password, _Gender, _Birthday)
        {
            BookCards = new List<OneSideCard<Book>>();            
            sSerialNumber = ++SerialNumber;
            ID = $"M-{SerialNumber}";
            Members.Add(this);
        }
       
        //without Parameters
        public Member() 
        {
            BookCards = new List<OneSideCard<Book>>();
            ID = $"M-{++SerialNumber}";
            Members.Add(this);
        }

        #endregion

        #region Methods

        public void SetCard(OneSideCard<Book> BookCard)
        {
            BookCards.Add(BookCard);
            StaticBookCards.Add(BookCard);            
        }

        public void GetCards()
        {
            PrintCards(NumberOfBorrowedBooks, BookCards);           
        }
        
        #endregion

        #region Static Methods
        
        public static void AllBookCards()
        {
            PrintCards(StaticNumberOfBorrowedBooks, StaticBookCards);            
        }

       

        public static bool IsEmailPasswordCorrect(string _Email, string _Password)
        {
            foreach (var member in Members)
            {
                if (member.Email == _Email)
                {
                    if (member.Password == _Password) return true;
                    else return false;
                }
            }
            //The Email or Password that you've entered is incorrect
            return false;
        }

        #endregion

        #region Override Mehods

        public override string ToString()
        {
            return $"Name : {Name}\n ID: {ID}\n Phone: {Phone}  Email: {Email}";
        }

        #endregion
    }
}