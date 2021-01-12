using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.ViewModel
{
    public class HotelViewModel
    {
        public int HotelID { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public string ContactNumber { get; set; }
        public string ContactPerson { get; set; }
        public string Website { get; set; }
        public string Fackbook { get; set; }
        public string Twitter { get; set; }
        public bool IsActive { get; set; }
    }
}
