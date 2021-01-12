using HMS.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Data.Interface
{
    public interface IBookingRepository
    {
        List<Booking> GetBookingDetails();
        Booking GetBooking(int id);
        bool InsertBooking(Booking booking);
        bool UpdateBooking(Booking booking);
        bool DeleteBooking(int id);
    }
}
