using System;
using System.Collections.Generic;
using System.Text;


namespace LibraryApp
{
    abstract class Card
    {
        public int CardID { get; }
        private static int SerialNumber = 659846153;
        public DateTime BorrowDate;
        public string ReturnDate
        {
            get
            {
                return BorrowDate.AddDays(14).ToString();
            }
        }
        public Card(bool Change)
        {
            if (Change)
            {
                CardID = ++SerialNumber;
            }
            else
                CardID = SerialNumber;

        }
       
    }
}
