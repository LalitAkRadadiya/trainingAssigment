using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using MVC.Models;
using System.Web.Mvc;

namespace MVC.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        // GET: Product
        
        public ActionResult Index()
        {
            IEnumerable<mvcProductModel> productList = null;
            HttpClient hc = new HttpClient();

            hc.BaseAddress = new Uri("https://localhost:44395/api/");
            var consumeapi = hc.GetAsync("Products");
            consumeapi.Wait();

            var readdata = consumeapi.Result;
            if (readdata.IsSuccessStatusCode)
            {
                var displaydata = readdata.Content.ReadAsAsync<IList<mvcProductModel>>();
                displaydata.Wait();

                productList = displaydata.Result;
            }
            return View(productList);

        }


        public ActionResult AddOrEdit(int id =0)
        {
            if (id == 0)
            {
                return View(new mvcProductModel());

            }
            else
            {

                HttpResponseMessage res = GlobalVariables.WebApiClint.GetAsync("Products/"+id.ToString()).Result;
                return View(res.Content.ReadAsAsync<mvcProductModel>().Result);
            }

        }
        [HttpPost]
        public ActionResult AddOrEdit(mvcProductModel pro)
        {
            if(pro.ProductID == 0)
            {
                HttpResponseMessage res = GlobalVariables.WebApiClint.PostAsJsonAsync("Products", pro).Result;
                TempData["SuccessMessage"] = "Saved SuccessFully ";

            }
            else {
                HttpResponseMessage res = GlobalVariables.WebApiClint.PutAsJsonAsync("Products/" + pro.ProductID, pro).Result;
                TempData["SuccessMessage"] = "Updated SuccessFully ";
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {

            HttpResponseMessage res = GlobalVariables.WebApiClint.DeleteAsync("Products/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Delete SuccessFully ";

            return RedirectToAction("Index");
        }
    }
}