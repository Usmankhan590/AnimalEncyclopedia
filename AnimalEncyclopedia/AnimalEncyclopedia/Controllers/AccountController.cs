using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnimalEncyclopedia.Models;
namespace AnimalEncyclopedia.Controllers
{
    public class AccountController : Controller
    {
        Database1Entities db = new Database1Entities();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Table tb)
        {
            var login = db.Tables.Where(a => a.Email == tb.Email && a.Password == tb.Password).FirstOrDefault();
            if (login != null)
            {
                Session["userId"] = login.Id;
                Session["uname"] = login.FirstName;
                Session["userImg"] = login.Img;
                ViewBag.Id = Session["uname"].ToString();
                if (login.RoleId == 1)
                {

                    ViewBag.ID = Session["Uname"].ToString();
                    return RedirectToAction("DashBoard", "Admin");

                }
                else
                {
                    Session["usname"] = login.FirstName;
                    Session["userImgs"] = login.Img;
                    
                    return RedirectToAction("Index", "User");
                }
            }
            else
            {
                ViewBag.er = "Username or Password is incorrect";
            }

            return View();


        }
  
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(Table tb, HttpPostedFileBase img)
        {
            var checkEmail = db.Tables.Where(a => a.Email == tb.Email).FirstOrDefault();
            if (ModelState.IsValid && img.ContentLength > 0)
            {



                if (checkEmail != null)
                {
                    ViewBag.error = "Email already exists!";
                   
                }

                else
                {
                    img.SaveAs(Server.MapPath("~/Content/userimg/" + img.FileName));
                    tb.Img = img.FileName;
                    tb.RoleId = 2;


                    db.Tables.Add(tb);

                    db.SaveChanges();

                    //return View("Login");

                }
            }
            return View("Login");

        }
     

        public ActionResult Logout()
        {
            Session["userId"] = null;
            Session["uname"] = null;
            Session["userImg"] = null;
            return RedirectToAction("Login", "Account");
        }


       
    }
}