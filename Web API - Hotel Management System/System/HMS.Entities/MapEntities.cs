using AutoMapper;
using HMS.Data.Model;
using HMS.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
    class MapEntities
    {
        public KeyValuePair<Hotel, HotelViewModel> MapDealerViewModel()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Hotel, HotelViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new Hotel();
            var destination = mapper.Map<Hotel, HotelViewModel>(source);
            return new KeyValuePair<Hotel, HotelViewModel>(source, destination);
        }

        public KeyValuePair<Room, RoomViewModel> MapCustomerViewModel()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Room, RoomViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new Room();
            var destination = mapper.Map<Room, RoomViewModel>(source);
            return new KeyValuePair<Room, RoomViewModel>(source, destination);
        }

        public KeyValuePair<Booking, BookingViewModel> MapVehicleViewModel()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Booking, BookingViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new Booking();
            var destination = mapper.Map<Booking, BookingViewModel>(source);
            return new KeyValuePair<Booking, BookingViewModel>(source, destination);
        }
    }
}
