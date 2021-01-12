using HMS.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Data.Interface
{
    public interface IHotelRepository
    {
        List<Hotel> GetHotelDetails();
        Hotel GetHotelById(int id);
        bool InsertHotel(Hotel hotel);
        bool UpdateHotel(Hotel hotel);
        bool DeleteHotel(int id);
    }
}
