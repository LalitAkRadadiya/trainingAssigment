using HMS.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Busniess.Interface
{
    public interface IHotelManager
    {
        List<HotelViewModel> GetHotelDetails();
        //HotelViewModel GetHotelById(int id);
        bool InsertHotel(HotelViewModel hotel);
        bool UpdateHotel(HotelViewModel hotel);
        bool DeleteHotel(int id);
    }
}