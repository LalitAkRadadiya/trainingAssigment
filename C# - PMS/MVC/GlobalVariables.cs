using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Net.Http.Headers;
namespace MVC
{
    public static class GlobalVariables
    {
        public static HttpClient WebApiClint = new HttpClient();

        static GlobalVariables()
        {
            WebApiClint.BaseAddress = new Uri("https://localhost:44395/api/");
            WebApiClint.DefaultRequestHeaders.Clear();
            WebApiClint.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("aplication/json"));
        }
    }
}