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
    public class RoomRepository : IRoomRepository
    {
        public AssignmentDBEntities _entities;

        public RoomRepository(AssignmentDBEntities hMSEntities)
        {
            _entities = hMSEntities;
        }

        public List<Room> GetRoomDetails()
        {
            return _entities.Rooms.ToList();
        }

        public Room GetRoom(int id)
        {
            Room room = _entities.Rooms.Find(id);
            return room;
        }

        public bool InsertRoom(Room room)
        {
            bool status = false;

            Room roomTemp = new Room();
            roomTemp = room;
            _entities.Rooms.Add(roomTemp);
            if (_entities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }

        public bool UpdateRoom(Room room)
        {
            bool status = false;
            Room roomTemp = new Room();
            roomTemp = room;
            _entities.Entry(room).State = EntityState.Modified;
            if (_entities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }

        public bool DeleteRoom(int id)
        {
            bool status = false;
            Room room = new Room();
            room = _entities.Rooms.Find(id);
            _entities.Rooms.Remove(room);
            if (_entities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
