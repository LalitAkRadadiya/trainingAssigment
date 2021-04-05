using PMS.BAL.Manager;
using PMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PMS.WebApi.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductManager _productManager;

        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;
        }

        [HttpGet]
        public IHttpActionResult GetAllProduct()
        {
            return Ok(_productManager.GetProducts());
        }

        [HttpPost]
        public IHttpActionResult AddProduct([FromBody]Product product)
        {
            if (ModelState.IsValid)
            {
                string result = _productManager.AddProduct(product);
                if(result == "Add Successfully")
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }
        }
        [HttpDelete]
        public IHttpActionResult DeleteProduct(int id)
        {
            if (id != null)
            {
                return Ok(_productManager.DeleteProduct(id));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut]
        public IHttpActionResult UpdateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                string result = _productManager.UpdateProduct(product);
                if (result == "update Successfully")
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }
        }
    }
}
