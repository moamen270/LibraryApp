using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    class MemberCard:Card
    {
        public Member Member;
        private static int NumberOfMemberCards=0;

        public MemberCard(Member member):base(false)
        {
            Member = member;
            BorrowDate = DateTime.Now;
            NumberOfMemberCards++;
        }
        public override string ToString()
        {
            
            StringBuilder MemberCard = new StringBuilder();
            MemberCard.AppendLine($"Borrow Date: {BorrowDate.ToShortDateString()}\tReturn Date: {ReturnDate}");
            MemberCard.AppendLine($"Member Name: {Member.Name}\tMember ID: {Member.ID}");
            MemberCard.AppendLine($"Serial Number: {CardID}");
            return MemberCard.ToString();
        }

    }
}
