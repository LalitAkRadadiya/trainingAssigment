using HMS.Business.Interface;
using HMS.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotelManagementSystem.Controllers
{
    public class BookingController : ApiController
    {
        private IBookingManager BookingManager { get; set; }

        public BookingController() { }

        public BookingController(IBookingManager bookingManager)
        {
            BookingManager = bookingManager;
        }

        public IHttpActionResult GetBookingDetails()
        {
            var bookings = BookingManager.GetBookingDetails();
            if (bookings == null)
            {
                return NotFound();
            }
            return Ok(bookings);
        }


        public IHttpActionResult GetBooking(int id)
        {
            var hotel = BookingManager.GetBooking(id);
            if (hotel == null)
            {
                return NotFound();
            }
            return Ok(hotel);
        }

        public bool InsertBooking(BookingViewModel bookingViewModel)
        {
            bool status = false;
            if (BookingManager.InsertBooking(bookingViewModel))
            {
                status = true;
            }
            return status;
        }

        public bool UpdateBooking(int id, BookingViewModel bookingViewModel)
        {
            if (id == bookingViewModel.BookingID)
            {
                return BookingManager.UpdateBooking(bookingViewModel);
            }
            return false;
        }

        public bool DeleteBooking(int id)
        {///
            return BookingManager.DeleteBooking(id);
        }

        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}