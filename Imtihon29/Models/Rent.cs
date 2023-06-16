using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon29.Models
{
    internal class Rent
    {
        public string Fullname { get; set; }

        public string PasportData { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime DeleveryDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public string AddInformation { get; set; }

        public Book RentBook { get; set; }

        public bool Submitted { get; set; } = false;

        public Rent(string fullname, string pasportData, 
                    string phoneNumber,  DateTime deleveryDate, 
                    DateTime returnDate, Book rentBook)
        {
            Fullname = fullname;
            PasportData = pasportData;
            PhoneNumber = phoneNumber;
            DeleveryDate = deleveryDate;
            ReturnDate = returnDate;
            RentBook = rentBook;
        }
    }
}
