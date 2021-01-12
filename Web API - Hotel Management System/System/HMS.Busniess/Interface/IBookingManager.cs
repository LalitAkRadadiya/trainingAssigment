using HMS.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Business.Interface
{
    public interface IBookingManager
    {
        List<BookingViewModel> GetBookingDetails();
        BookingViewModel GetBooking(int id);
        bool InsertBooking(BookingViewModel booking);
        bool UpdateBooking(BookingViewModel booking);
        bool DeleteBooking(int id);
    }
}
