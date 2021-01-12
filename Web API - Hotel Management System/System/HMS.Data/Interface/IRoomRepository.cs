using HMS.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Data.Interface
{
    public interface IRoomRepository
    {
        List<Room> GetRoomDetails();
        Room GetRoom(int id);
        bool InsertRoom(Room room);
        bool UpdateRoom(Room room);
        bool DeleteRoom(int id);
    }
}
