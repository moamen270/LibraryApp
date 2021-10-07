using System;
using System.Collections.Generic;
using System.Text;


namespace LibraryApp
{
    abstract class Card
    {
        public int CardID { get; }
        private static int _Serialnumber;
        public DateTime BorrowDate;
        public string ReturnDate { get => BorrowDate.AddDays(14).ToString(); }


        public Card(int SerialNumber)
        {
            _Serialnumber = SerialNumber;
            CardID = _Serialnumber;           
        }

        public Card()
        {
            CardID = _Serialnumber;
        }
       
    }
}
