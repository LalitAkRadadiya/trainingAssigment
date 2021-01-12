using AutoMapper;
using HMS.Busniess.Interface;
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
    public class HotelManager : IHotelManager
    {
        private IHotelRepository HotelRepository;

        public HotelManager() { }

        public HotelManager(IHotelRepository hotelRepository)
        {
            HotelRepository = hotelRepository;
        }

        public List<HotelViewModel> GetHotelDetails()
        {
            List<HotelViewModel> hotelViewModels = new List<HotelViewModel>();
            var hotels = HotelRepository.GetHotelDetails();
            foreach (var hotel in hotels)
            {
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Hotel, HotelViewModel>();
                });

                IMapper mapper = config.CreateMapper();
                var source = new Hotel();
                source = hotel;
                var destination = mapper.Map<Hotel, HotelViewModel>(source);
                hotelViewModels.Add(destination);
            }
            return hotelViewModels;
        }

        public HotelViewModel GetHotelById(int id)
        {
            Hotel hotel = HotelRepository.GetHotelById(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Hotel, HotelViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = hotel;
            var destination = mapper.Map<Hotel, HotelViewModel>(source);
            return destination;
        }

        public bool InsertHotel(HotelViewModel hotel)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<HotelViewModel, Hotel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = hotel;
            var destination = mapper.Map<HotelViewModel, Hotel>(source);

            bool status = HotelRepository.InsertHotel(destination);
            return status;
        }

        public bool UpdateHotel(HotelViewModel hotel)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<HotelViewModel, Hotel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = hotel;
            var destination = mapper.Map<HotelViewModel, Hotel>(source);

            bool status = HotelRepository.InsertHotel(destination);
            return status;
        }

        public bool DeleteHotel(int id)
        {
            bool status = HotelRepository.DeleteHotel(id);
            return status;
        }
    }
}
