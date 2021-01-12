using AutoMapper;
using HMS.Business.Interface;
using HMS.Data.Interface;
using HMS.Data.Model;
using HMS.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Busniess
{
    public class BookingManager : IBookingManager
    {
        private IBookingRepository BookingRepository;

        public BookingManager(IBookingRepository bookingRepository)
        {
            BookingRepository = bookingRepository;
        }

        public List<BookingViewModel> GetBookingDetails()
        {
            List<BookingViewModel> bookingViewModels = new List<BookingViewModel>();
            var bookings = BookingRepository.GetBookingDetails();
            foreach (var booking in bookings)
            {
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Booking, RoomViewModel>();
                });

                IMapper mapper = config.CreateMapper();
                var source = new Booking();
                source = booking;
                var destination = mapper.Map<Booking, BookingViewModel>(source);
                bookingViewModels.Add(destination);
            }
            return bookingViewModels;
        }

        public BookingViewModel GetBooking(int id)
        {
            Booking booking = BookingRepository.GetBooking(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Booking, BookingViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = booking;
            var destination = mapper.Map<Booking, BookingViewModel>(source);
            return destination;
        }

        public bool InsertBooking(BookingViewModel booking)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<BookingViewModel, Booking>();
            });

            IMapper mapper = config.CreateMapper();
            var source = booking;
            var destination = mapper.Map<BookingViewModel, Booking>(source);

            bool status = BookingRepository.InsertBooking(destination);
            return status;
        }

        public bool UpdateBooking(BookingViewModel booking)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<BookingViewModel, Booking>();
            });

            IMapper mapper = config.CreateMapper();
            var source = booking;
            var destination = mapper.Map<BookingViewModel, Booking>(source);

            bool status = BookingRepository.InsertBooking(destination);
            return status;
        }

        public bool DeleteBooking(int id)
        {
            bool status = BookingRepository.DeleteBooking(id);
            return status;
        }
    }
}
