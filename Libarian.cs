using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryApp
{
    class Libarian : Employee
    {
        #region Attributs
        private static int SerialNumber = 100;
        private static List<BorrowCard> BorrowCards = new List<BorrowCard>();
        private static List<Libarian> libarians = new List<Libarian>();
        private static int NumberOfBorrowCards { get => BorrowCards.Count; }
        #endregion

        #region Constructor
        public Libarian(string Name, string Phone, string Email, string _Password, Gender gender, DateTime Birthday, double Salary)
           : base(Name, gender, Phone, Email, _Password, Birthday, Salary)
        {
            ID = $"L-{++SerialNumber}";
            libarians.Add(this);
        }
        #endregion

        #region Methods

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

        public void GetCards()
        {
            PrintList(NumberOfBorrowCards,BorrowCards);           
        }
        
        #endregion

        #region Static Methods
        public static void PrintList(int check,List<BorrowCard> ListOfCards)
        {
            if (check > 0)
            {
                int i = 1;
                foreach (var item in ListOfCards)
                {
                    Console.WriteLine((i++) + "- " + item);
                }
            }
            else
                Console.WriteLine("Empty");
        }

        public static void PrintList(int check, List<OneSideCard<Book>> ListOfCards)
        {
            if (check > 0)
            {
                int i = 1;
                foreach (var item in ListOfCards)
                {
                    Console.WriteLine((i++) + "- " + item);
                }
            }
            else
                Console.WriteLine("Empty");
        }

        public static void PrintList(int check, List<OneSideCard<Member>> ListOfCards)
        {
            if (check > 0)
            {
                int i = 1;
                foreach (var item in ListOfCards)
                {
                    Console.WriteLine((i++) + "- " + item);
                }
            }
            else
                Console.WriteLine("Empty");
        }

        public static void AllBorrowCards()
        {
            PrintList(NumberOfBorrowCards, BorrowCards);          
        }

        #endregion

        #region Override Methods

        public override bool IsPasswordCorrect(string Password)
        {
            return base.IsPasswordCorrect(Password);
        }

        public override string ToString()
        {
            return $"Libarian Name : {Name}\tLibarian ID: {ID}";
        }

        #endregion

        // Inner Class - Helper Class
        internal class BorrowCard : Card
        {
            #region Attrebuts
            public Libarian Libarian;
            public OneSideCard<Member> MemberCard;
            public OneSideCard<Book> BookCard;
            private static int SerialNumber = 5000000;
            #endregion

            #region Constructor

            public BorrowCard(Member _Member, Book _Book, Libarian _Libarian) : base(SerialNumber)
            {
                BorrowDate = DateTime.Now;
                OneSideCard<Member> member = new OneSideCard<Member>(_Member);
                OneSideCard<Book> book = new OneSideCard<Book>(_Book);
                Libarian = _Libarian;
                MemberCard = member;
                BookCard = book;
                _Member.SetCard(book);
                _Book.SetCard(member);
                SerialNumber++;
            }
            #endregion

            #region Override Methods
            public override string ToString()
            {
                StringBuilder BorrowCard = new StringBuilder();

                BorrowCard.AppendLine($"Borrow Date: {BorrowDate.ToShortDateString()}\tReturn Date: {ReturnDate}");
                BorrowCard.AppendLine(" " + MemberCard.PrintIn());
                BorrowCard.AppendLine(" " + BookCard.PrintIn());
                BorrowCard.AppendLine("   " + Libarian.ToString());
                BorrowCard.AppendLine("   " + $"Card Serial: {CardID}");

                return BorrowCard.ToString();
            }
            #endregion
        }

        public bool isit(int x , out string y)
        {
            y = x.ToString();
            return true;
        }
        public int addnums(int x,int y , int[] restofnumbers =null)
        {
            int result = 0;
            if(restofnumbers != null)
            {
                foreach (int item in restofnumbers)
                {
                    result += item;
                } 
                return result + x + y;
            }
            else
                return(x+y);
        }


        public string this[int MemberID]
        {
            get
            {
                if (Members.FirstOrDefault(memb => memb.sSerialNumber == MemberID).Name.ToString() == null) return "Null";
                else
                return Members.FirstOrDefault(memb => memb.sSerialNumber == MemberID).Name.ToString();
            }
        }

        public int this[ string MemberName] { get => Members.FirstOrDefault(memb => memb.Name == MemberName).sSerialNumber; }

        public List<Member> Members = new List<Member>
         {
             new Member("ahmed","01111111","ahmed@gmail.com","ahmed123",Gender.Male,DateTime.Now.AddMonths(-210)),
             new Member("maged","01111111","maged@gmail.com","maged123",Gender.Male,DateTime.Now.AddMonths(-210)),
             new Member("khalil","01111111","kalil@gmail.com","kalil123",Gender.Male,DateTime.Now.AddMonths(-210)),
             new Member("hazem","01111111","hazem@gmail.com","hazem123",Gender.Male,DateTime.Now.AddMonths(-210)),
             new Member("mohamed","01111111","mohamed@gmail.com","mohamed123",Gender.Male,DateTime.Now.AddMonths(-210)),
             new Member("john","01111111","john@gmail.com","john123",Gender.Male,DateTime.Now.AddMonths(-210)),
             new Member("ziad","01111111","ziad@gmail.com","ziad123",Gender.Male,DateTime.Now.AddMonths(-210)),
             new Member("ghanem","01111111","ghanem@gmail.com","ghanem123",Gender.Male,DateTime.Now.AddMonths(-210)),
             new Member("gabr","01111111","gabr@gmail.com","gabr123",Gender.Male,DateTime.Now.AddMonths(-210)),
             new Member("zin","01111111","zin@gmail.com","zin123",Gender.Male,DateTime.Now.AddMonths(-210)),
         };
    }
}
