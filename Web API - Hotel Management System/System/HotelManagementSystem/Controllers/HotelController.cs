using HMS.Busniess.Interface;
using HMS.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace HotelManagementSystem.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class HotelController : ApiController
    {
        private IHotelManager HotelManager { get; set; }
        public HotelController() { }

        [HttpGet]
        public IHttpActionResult GetHotelDetails()
        {
            var hotels = HotelManager.GetHotelDetails();
            if (hotels == null)
            {
                return NotFound();
            }
            return Ok(hotels);
        }

        //public IHttpActionResult GetHotelById(int id)
        //{
        //    var hotels = HotelManage.GetHotelById(id);
        //    if (hotels == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(hotels);
        //}

        public bool InsertHotel(HotelViewModel hotelViewModel)
        {
            return HotelManager.InsertHotel(hotelViewModel);
        }

        public bool UpdateHotel(HotelViewModel hotelViewModel)
        {
            return HotelManager.UpdateHotel(hotelViewModel);
        }

        public bool DeleteHotel(int id)
        {
            return HotelManager.DeleteHotel(id);
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