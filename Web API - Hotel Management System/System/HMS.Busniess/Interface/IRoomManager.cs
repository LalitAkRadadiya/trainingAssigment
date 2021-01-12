using HMS.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Business.Interface
{
    public interface IRoomManager
    {
        List<RoomViewModel> GetRoomDetails();
        RoomViewModel GetRoom(int id);
        bool InsertRoom(RoomViewModel room);
        bool UpdateRoom(RoomViewModel room);
        bool DeleteRoom(int id);
    }
}

