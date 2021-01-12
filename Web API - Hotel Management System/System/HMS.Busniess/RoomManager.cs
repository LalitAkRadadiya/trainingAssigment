using AutoMapper;
using HMS.Business.Interface;
using HMS.Data;
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
    public class RoomManager : IRoomManager
    {
        private IRoomRepository RoomRepository; 

        public RoomManager(IRoomRepository roomRepository)
        {
            RoomRepository = roomRepository;
        }

        public List<RoomViewModel> GetRoomDetails()
        {
            List<RoomViewModel> roomViewModels = new List<RoomViewModel>();
            var rooms = RoomRepository.GetRoomDetails();
            foreach (var room in rooms)
            {
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Room, RoomViewModel>();
                });

                IMapper mapper = config.CreateMapper();
                var source = new Room();
                source = room;
                var destination = mapper.Map<Room, RoomViewModel>(source);
                roomViewModels.Add(destination);
            }
            return roomViewModels;
        }

        public RoomViewModel GetRoom(int id)
        {
            Room room = RoomRepository.GetRoom(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Room, RoomViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = room;
            var destination = mapper.Map<Room, RoomViewModel>(source);
            return destination;
        }

        public bool InsertRoom(RoomViewModel room)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<RoomViewModel, Room>();
            });

            IMapper mapper = config.CreateMapper();
            var source = room;
            var destination = mapper.Map<RoomViewModel, Room>(source);

            bool status = RoomRepository.InsertRoom(destination);
            return status;
        }

        public bool UpdateRoom(RoomViewModel room)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<RoomViewModel, Room>();
            });

            IMapper mapper = config.CreateMapper();
            var source = room;
            var destination = mapper.Map<RoomViewModel, Room>(source);

            bool status = RoomRepository.InsertRoom(destination);
            return status;
        }

        public bool DeleteRoom(int id)
        {
            bool status = RoomRepository.DeleteRoom(id);
            return status;
        }
    }
}
