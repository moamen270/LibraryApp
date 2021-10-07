using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    abstract class PersonWithContact : Person
    {
        public string Phone { get; }
        public string Email { get; }
        protected string Password { get; }
        public static int x = 78453;

        public PersonWithContact(string _Name, string _Phone, string _Email, string _Password, Gender _Gender, DateTime _Birthday)
            : base(_Name, _Gender, _Birthday)
        {
            Phone = _Phone;
            Email = _Email;
            Password = _Password;
        }
        public virtual bool IsPasswordCorrect(string Password)
        {
            if (this.Password == Password) return true;
            return false;

        }
        
        public PersonWithContact()
        {

        }


        public void PrintCards(int check, List<Card> ListOfCards)
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



        public static void PrintCards(int check, List<OneSideCard<Member>> ListOfCards)
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

        public static void PrintCards(int check, List<OneSideCard<Book>> ListOfCards)
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
    }
}
