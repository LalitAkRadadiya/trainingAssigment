using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.ViewModel
{
    public class BookingViewModel
    {
        public int BookingID { get; set; }
        public Nullable<System.DateTime> BookingDate { get; set; }
        public string StatusofBooking { get; set; }
        public Nullable<int> RoomID { get; set; }

    }
}
