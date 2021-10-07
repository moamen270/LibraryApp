using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryApp
{
    public interface tools
    {
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Author a1 = new Author("moamen", Gender.Male, DateTime.Now);
/*            Libarian L1 = new Libarian("kaas", "010000000", "kass@gmail.com", "kass123", Gender.Male, DateTime.Now, 4851);
*/            Member m1 = new Member("moamen", "010000000", "moamen@gmail.com", "moamen123", Gender.Male, DateTime.Now);
            
            Book b1 = new Book("elesm", a1, "ay7aga", 5);
            Book b2 = new Book("elesm", a1, "ay7aga", 5);

            Dictionary<int, Member> Members = new Dictionary<int, Member>
            {
                { 1 ,new Member("ahmed", "01111111", "ahmed@gmail.com", "ahmed123", Gender.Male, DateTime.Now.AddMonths(-210)) },
                { 2 ,new Member("ahmed", "01111111", "ahmed@gmail.com", "ahmed123", Gender.Male, DateTime.Now.AddMonths(-210)) },
                { 3 ,new Member("ahmed", "01111111", "ahmed@gmail.com", "ahmed123", Gender.Male, DateTime.Now.AddMonths(-210)) },
                { 4 ,new Member("ahmed", "01111111", "ahmed@gmail.com", "ahmed123", Gender.Male, DateTime.Now.AddMonths(-210)) },
                { 5 ,new Member("ahmed", "01111111", "ahmed@gmail.com", "ahmed123", Gender.Male, DateTime.Now.AddMonths(-210)) },
                { 6 ,new Member("ahmed", "01111111", "ahmed@gmail.com", "ahmed123", Gender.Male, DateTime.Now.AddMonths(-210)) },
                { 7 ,new Member("ahmed", "01111111", "ahmed@gmail.com", "ahmed123", Gender.Male, DateTime.Now.AddMonths(-210)) },
                { 8 ,new Member("ahmed", "01111111", "ahmed@gmail.com", "ahmed123", Gender.Male, DateTime.Now.AddMonths(-210)) },
                { 9 ,new Member("ahmed", "01111111", "ahmed@gmail.com", "ahmed123", Gender.Male, DateTime.Now.AddMonths(-210)) }
            };

            Member[] memb = new Member[3];
            memb[0] = new Member();
            memb[1] = new Member();
            memb[2] = new Member();

            
            Dictionary<int,Member> MmDec = memb.ToDictionary(mem => mem.sSerialNumber , mem => mem);
            MmDec.Add(4, new Member());

            foreach (var item in MmDec.Values)
            {
                Console.WriteLine(item);
            }








            /*L1.Borrow(m1, b1);
              L1.Borrow(m1, b2);
              L1.GetCards();
              m1.GetCards();
              b1.GetCards();
              b2.GetCards();
              Libarian.AllBorrowCards();
              Member.AllBookCards();
              Book.AllMemberCards();*/


        }
    }
}
