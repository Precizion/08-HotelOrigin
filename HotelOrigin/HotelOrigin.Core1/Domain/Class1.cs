using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrigin.Core
{
    public class Customer
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public string Notes { get; set; }
    }
}
