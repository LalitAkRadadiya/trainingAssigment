﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Data.Model
{




    public class Hotel
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public string ContactNumber { get; set; }
        public string ContactPerson { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public virtual  List<Room> Rooms { get; set; }
    }


}
