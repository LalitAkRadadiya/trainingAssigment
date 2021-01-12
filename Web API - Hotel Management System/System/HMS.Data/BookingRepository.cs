using HMS.Data.Interface;
using HMS.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Data
{
    public class BookingRepository : IBookingRepository
    {
        public AssignmentDBEntities _entities;

        public BookingRepository(AssignmentDBEntities hMSEntities)
        {
            _entities = hMSEntities;
        }

        public List<Booking> GetBookingDetails()
        {
            return _entities.Bookings.ToList();
        }

        public Booking GetBooking(int id)
        {
            Booking booking = _entities.Bookings.Find(id);
            return booking;
        }

        public bool InsertBooking(Booking booking)
        {
            bool status = false;

            Booking bookingTemp = new Booking();
            bookingTemp = booking;
            _entities.Bookings.Add(bookingTemp);
            if (_entities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }

        public bool UpdateBooking(Booking booking)
        {
            bool status = false;
            Booking bookingTemp = new Booking();
            bookingTemp = booking;
            _entities.Entry(booking).State = EntityState.Modified;
            if (_entities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }

        public bool DeleteBooking(int id)
        {
            bool status = false;
            Booking booking = new Booking();
            booking = _entities.Bookings.Find(id);
            _entities.Bookings.Remove(booking);
            if (_entities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
