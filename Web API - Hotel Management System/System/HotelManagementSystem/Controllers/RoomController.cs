using HMS.Business.Interface;
using HMS.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotelManagementSystem.Controllers
{
    public class RoomController : ApiController
    {
        private IRoomManager RoomManage { get; set; }

        public RoomController() { }

        public RoomController(IRoomManager roomManager)
        {
            RoomManage = roomManager;
        }

        public IHttpActionResult GetRoomDetails()
        {
            var rooms = RoomManage.GetRoomDetails();
            if (rooms == null)
            {
                return NotFound();
            }
            return Ok(rooms);
        }

        public IHttpActionResult GetRoom(int id)
        {
            var room = RoomManage.GetRoom(id);
            if (room == null)
            {
                return NotFound();
            }
            return Ok(room);
        }

        public bool InsertRoom(RoomViewModel roomViewModel)
        {
            return RoomManage.InsertRoom(roomViewModel);
        }

        public bool UpdateRoom(RoomViewModel roomViewModel)
        {
            return RoomManage.UpdateRoom(roomViewModel);
        }

        public bool DeleteRoom(int id)
        {
            return RoomManage.DeleteRoom(id);
        }
        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}