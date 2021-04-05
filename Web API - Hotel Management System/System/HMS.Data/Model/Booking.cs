using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Data.Model
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
        public string StatusofBooking { get; set; }
        public int RoomID { get; set; }
        public virtual Room Room { get; set; }
    }


}
