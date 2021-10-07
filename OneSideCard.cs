using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    class OneSideCard<MemberOrBook> : Card
    {
        private object _MemberOrBook;

        public OneSideCard(MemberOrBook memberOrBook)
        {
            try
            {
                if (!(memberOrBook is Member || memberOrBook is Book))
                    throw new FormatException("Use Only Member or Book type");
                _MemberOrBook = memberOrBook;
                BorrowDate = DateTime.Now;            
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            


        }

        public string PrintIn()
        {
            /*this.GetType().ToString() == "LibraryApp.OneSideCard`1[LibraryApp.Member]" ||*/
            if (_MemberOrBook is Member)
            {
                return "  " + $"Member Name: {((Member)_MemberOrBook).Name}\tMember ID: {((Member)_MemberOrBook).ID}";
            }
            else
            {
                return "  " + $"Book Name: {((Book)_MemberOrBook).Name}\tBook ID: {((Book)_MemberOrBook).ID}";
            }
        }


        public override string ToString()
        {
            StringBuilder BorrowCard = new StringBuilder();
            BorrowCard.AppendLine($"Borrow Date: {BorrowDate.ToShortDateString()}\tReturn Date: {ReturnDate}");
            if (_MemberOrBook is Member)
            {
                BorrowCard.AppendLine("   " + $"Member Name: {((Member)_MemberOrBook).Name}\tMember ID: {((Member)_MemberOrBook).ID}");
                BorrowCard.AppendLine("   " + $"Serial Number: {CardID}");
                return BorrowCard.ToString();
            }
            else
            {
                BorrowCard.AppendLine("   " + $"Book Name: {((Book)_MemberOrBook).Name}\tBook ID: {((Book)_MemberOrBook).ID}");
                BorrowCard.AppendLine("   " + $"Serial Number: {CardID}");
                return BorrowCard.ToString();
            }

        }
       

    }
}

