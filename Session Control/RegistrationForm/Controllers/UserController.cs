using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationForm.Models;

namespace RegistrationForm.Controllers
{
    public class UserController : Controller
    {
        LoginEntities db = new LoginEntities();
        // GET: User
        public ActionResult Index()
        {
            return View();
            

        }
        [HttpPost]
        public ActionResult Index(Student s)
        {
            var User = db.Students.Where(model => model.Email == s.Email && model.PassWord == s.PassWord).FirstOrDefault();
            if(User!=null)
            {
                Session["UserId"] = s.Id.ToString();
                Session["Username"] = s.Email.ToString();


                TempData["loginstatus"]= "<script>alert('login succefully !!')</script>";
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ViewBag.ErrorMeassage= "<script>alert('email and password does not match !!')</script>";
            }

            return View();
        }
        public ActionResult Registre()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registre(Student s)
        {
            if (ModelState.IsValid == true)
            {
                db.Students.Add(s);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    ViewBag.InsertMeassage = "<script>alert('register succefully !!')</script>";
                    ModelState.Clear();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.InsertMeassage = "<script>alert('not register succefully !!')</script>";
                }
            }
            return View();
        }
    }
}