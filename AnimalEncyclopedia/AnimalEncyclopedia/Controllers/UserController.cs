using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnimalEncyclopedia.Models;

namespace AnimalEncyclopedia.Controllers
{
    public class UserController : Controller
    {
        Database1Entities db = new Database1Entities();
        // GET: User
        public ActionResult Index()
        {
            dynamic mymodel = new ExpandoObject();
            ViewModel mymodel2 = new ViewModel();
            mymodel2.Cards = db.cards.ToList();
            mymodel2.Researches = db.researches.ToList();
            return View(mymodel2);
        }


        public ActionResult Animals()
        {
            return View();
        }

        public ActionResult Animals_Details() 
        {
            dynamic mymod = new ExpandoObject();
            AnimalsModel mymodel3 = new AnimalsModel();
            mymodel3.Amphibians = db.Amphibians.ToList();
            mymodel3.Birds = db.Birds.ToList();
            mymodel3.Animals = db.Animals.ToList();

            return View(mymodel3);
         
        }

        public ActionResult Doctors()
        {
            return View(db.Docts.ToList());
        }

        public ActionResult Testimonials()
        {
            return View(db.Reviews.ToList());
        }

        public ActionResult Books()
        {
            return View(db.Books.ToList());
        }

        public ActionResult Review()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Review(Review rev, HttpPostedFileBase img)

        {
            if (img.ContentLength > 0)
            {
                //img.SaveAs(Server.MapPath("~/Content/Vimg/" + img.FileName));
                img.SaveAs(Server.MapPath("~/Content/reviews/" + img.FileName));
                rev.img = img.FileName;

            }

            db.Reviews.Add(rev);
            db.SaveChanges();
            return RedirectToAction("Testimonials");


        }

        public ActionResult EditUser(int id)
        {
            Table table = db.Tables.Where(x => x.Id == id).FirstOrDefault();
            TempData["id"] = id;
            Session["userId"] =id;
            TempData.Keep();
            return View(table);
        }
        [HttpPost]
        public ActionResult EditUser(Table table)
        {
            if (ModelState.IsValid)
            {
                int id = Convert.ToInt32(TempData["id"]);

                Table oldTable = db.Tables.Where(x => x.Id == id).FirstOrDefault();
                oldTable.FirstName = table.FirstName;
                oldTable.LastName = table.LastName;
                oldTable.Email = table.Email;
                oldTable.Password = table.Password;
                oldTable.Img = table.Img;

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }


    }

}
