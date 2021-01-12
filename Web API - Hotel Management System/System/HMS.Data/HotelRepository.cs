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
    public class HotelRepository : IHotelRepository
    {
        public AssignmentDBEntities _entities;

        public HotelRepository(AssignmentDBEntities hMSEntities)
        {
            this._entities = hMSEntities;
        }

        public List<Hotel> GetHotelDetails()
        {
            return _entities.Hotels.ToList();
           
        }

        public Hotel GetHotelById(int id)
        {
            Hotel hotel = _entities.Hotels.Find(id);
            return hotel;
        }

        public bool InsertHotel(Hotel hotel)
        {
            bool status = false;

            Hotel hotelTemp = new Hotel();
            hotelTemp = hotel;
            _entities.Hotels.Add(hotelTemp);
            if (_entities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }

        public bool UpdateHotel(Hotel hotel)
        {
            bool status = false;
            Hotel hotelTemp = new Hotel();
            hotelTemp = hotel;
            _entities.Entry(hotel).State = EntityState.Modified;
            if (_entities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }

        public bool DeleteHotel(int id)
        {
            bool status = false;
            Hotel hotel = new Hotel();
            hotel = _entities.Hotels.Find(id);
            _entities.Hotels.Remove(hotel);
            if (_entities.SaveChanges() > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
