using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.ViewModel
{
    public class RoomViewModel
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public string RoomCategory { get; set; }
        public Nullable<decimal> RoomPrice { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<int> HotelID { get; set; }
    }
}
