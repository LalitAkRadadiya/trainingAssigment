using HMS.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Data
{
    public class AssignmentDBEntities : DbContext
    {
        public AssignmentDBEntities() : base("HMSEntities")
        {
        }

        public DbSet<Hotel> Hotels
        {
            get; set;
        }

        public DbSet<Room> Rooms
        {
            get; set;
        }

        public DbSet<Booking> Bookings
        {
            get; set;
        }
    }
}
