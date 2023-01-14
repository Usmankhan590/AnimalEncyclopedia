using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnimalEncyclopedia.Models;
namespace AnimalEncyclopedia.Controllers
{
    public class AdminController : Controller
    {
        Database1Entities db = new Database1Entities();
        // GET: Admin
        public ActionResult DashBoard()
        {
            return View();
        }
        public ActionResult Add_Animal_Detail()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add_Animal_Detail(card ani, HttpPostedFileBase img)
        {
            if (img.ContentLength > 0)
            {
                //img.SaveAs(Server.MapPath("~/Content/Vimg/" + img.FileName));
                img.SaveAs(Server.MapPath("~/Content/Addimg/" + img.FileName));
                ani.images = img.FileName;
            }
            db.cards.Add(ani);
            db.SaveChanges();
            return RedirectToAction("Animals_Details");
        }
        public ActionResult Animals_Details()
        {
            return View(db.cards.ToList());
        }
        public ActionResult Edit_Animals(int id)
        {
            var edit = db.cards.Where(a => a.Id == id).FirstOrDefault();

            return View(edit);
        }
        [HttpPost]
        public ActionResult Edit_Animals(card ani, HttpPostedFileBase img, int id)
        {
            var edit = db.cards.Where(a => a.Id == id).FirstOrDefault();
            if (img != null)
            {
                if (img.ContentLength > 0)
                {
                    img.SaveAs(Server.MapPath("~/Content/Addimg/" + img.FileName));
                    edit.images = img.FileName;
                }

            }
            else
            {
                edit.images = ani.images;
            }
            edit.Title = ani.Title;
            edit.Description = ani.Description;
            db.SaveChanges();
            return RedirectToAction("Animals_Details");
        }
        public ActionResult Delete_Animal(int id)
        {
            var del = db.cards.Where(a => a.Id == id).FirstOrDefault();
            db.cards.Remove(del);
            db.SaveChanges();
            return RedirectToAction("Animals_Details");
        }

                                //DOCTOR
        public ActionResult Add_Doctors()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add_Doctors(Doct Doc, HttpPostedFileBase img)
        {
            if (img.ContentLength > 0)
            {
                //img.SaveAs(Server.MapPath("~/Content/Vimg/" + img.FileName));
                img.SaveAs(Server.MapPath("~/Content/DocImg/" + img.FileName));
                Doc.images = img.FileName;
            }
            db.Docts.Add(Doc);
            db.SaveChanges();
            return RedirectToAction("Doctor");
        }
        public ActionResult Doctor()
        {
            return View(db.Docts.ToList());
        }
        public ActionResult Edit_Doctors(int id)
        {
            var edit = db.Docts.Where(a => a.Id == id).FirstOrDefault();

            return View(edit);
        }
        [HttpPost]
        public ActionResult Edit_Doctors(Doct Doc, HttpPostedFileBase img, int id)
        {
            var edit = db.Docts.Where(a => a.Id == id).FirstOrDefault();
            if (img != null)
            {
                if (img.ContentLength > 0)
                {
                    img.SaveAs(Server.MapPath("~/Content/DocImg/" + img.FileName));
                    edit.images = img.FileName;
                }

            }
            else
            {
                edit.images = Doc.images;
            }
            edit.Title = Doc.Title;
            edit.About = Doc.About;
            db.SaveChanges();
            return RedirectToAction("Doctor");
        }
        public ActionResult Delete_Doctors(int id)
        {
            var del = db.Docts.Where(a => a.Id == id).FirstOrDefault();
            db.Docts.Remove(del);
            db.SaveChanges();
            return RedirectToAction("Doctor");
        }
                        
                                                //research

        public ActionResult Add_Research()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add_Research(research re, HttpPostedFileBase img)
        {
            if (img.ContentLength > 0)
            {
                //img.SaveAs(Server.MapPath("~/Content/Vimg/" + img.FileName));
                img.SaveAs(Server.MapPath("~/Content/Research/" + img.FileName));
                re.images = img.FileName;
            }
            db.researches.Add(re);
            db.SaveChanges();
            return RedirectToAction("Research");
        }
        public ActionResult Research()
        {
            return View(db.researches.ToList());
        }
        public ActionResult Edit_Research(int id)
        {
            var edit = db.researches.Where(a => a.Id == id).FirstOrDefault();

            return View(edit);
        }
        [HttpPost]
        public ActionResult Edit_Research(research re, HttpPostedFileBase img, int id)
        {
            var edit = db.researches.Where(a => a.Id == id).FirstOrDefault();
            if (img != null)
            {
                if (img.ContentLength > 0)
                {
                    img.SaveAs(Server.MapPath("~/Content/Research/" + img.FileName));
                    edit.images = img.FileName;
                }

            }
            else
            {
                edit.images = re.images;
            }
            edit.Title = re.Title;
            edit.Description = re.Description;
            db.SaveChanges();
            return RedirectToAction("Doctor");
        }
        public ActionResult Delete_Research(int id)
        {
            var del = db.researches.Where(a => a.Id == id).FirstOrDefault();
            db.researches.Remove(del);
            db.SaveChanges();
            return RedirectToAction("Research");
        }
                                     //Amphibians ANimals Birds

        public ActionResult Add_Amphibians()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add_Amphibians(Amphibian am, HttpPostedFileBase img)
        {
            if (img.ContentLength > 0)
            {
                //img.SaveAs(Server.MapPath("~/Content/Vimg/" + img.FileName));
                img.SaveAs(Server.MapPath("~/Content/AmpImg/" + img.FileName));
                am.images = img.FileName;
            }
            db.Amphibians.Add(am);
            db.SaveChanges();
            return RedirectToAction("Amphibians");
        }
        public ActionResult Amphibians()
        {
            return View(db.Amphibians.ToList());
        }
        public ActionResult Edit_Amphibians(int id)
        {
            var edit = db.Amphibians.Where(a => a.Id == id).FirstOrDefault();

            return View(edit);
        }
        [HttpPost]
        public ActionResult Edit_Amphibians(Amphibian am, HttpPostedFileBase img, int id)
        {
            var edit = db.Amphibians.Where(a => a.Id == id).FirstOrDefault();
            if (img != null)
            {
                if (img.ContentLength > 0)
                {
                    img.SaveAs(Server.MapPath("~/Content/AmpImg/" + img.FileName));
                    edit.images = img.FileName;
                }

            }
            else
            {
                edit.images = am.images;
            }
            edit.Title = am.Title;
            edit.Description = am.Description;
            db.SaveChanges();
            return RedirectToAction("Amphibians");
        }
        public ActionResult Delete_Amphibians(int id)
        {
            var del = db.Amphibians.Where(a => a.Id == id).FirstOrDefault();
            db.Amphibians.Remove(del);
            db.SaveChanges();
            return RedirectToAction("Amphibians");
        }

                                                          //Animals

        public ActionResult Add_WildAnimal()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add_WildAnimal(Animal an, HttpPostedFileBase img)
        {
            if (img.ContentLength > 0)
            {
                //img.SaveAs(Server.MapPath("~/Content/Vimg/" + img.FileName));
                img.SaveAs(Server.MapPath("~/Content/AddAnimal/" + img.FileName));
                an.images = img.FileName;
            }
            db.Animals.Add(an);
            db.SaveChanges();
            return RedirectToAction("WildAnimal");
        }
        public ActionResult WildAnimal()
        {
            return View(db.Animals.ToList());
        }
        public ActionResult Edit_WildAnimal(int id)
        {
            var edit = db.Animals.Where(a => a.Id == id).FirstOrDefault();

            return View(edit);
        }
        [HttpPost]
        public ActionResult Edit_WildAnimal(Animal an, HttpPostedFileBase img, int id)
        {
            var edit = db.Animals.Where(a => a.Id == id).FirstOrDefault();
            if (img != null)
            {
                if (img.ContentLength > 0)
                {
                    img.SaveAs(Server.MapPath("~/Content/AddAnimal/" + img.FileName));
                    edit.images = img.FileName;
                }

            }
            else
            {
                edit.images = an.images;
            }
            edit.Title = an.Title;
            edit.Description = an.Description;
            db.SaveChanges();
            return RedirectToAction("WildAnimal");
        }
        public ActionResult Delete_WildAnimal(int id)
        {
            var del = db.Animals.Where(a => a.Id == id).FirstOrDefault();
            db.Animals.Remove(del);
            db.SaveChanges();
            return RedirectToAction("WildAnimal");
        }




                                       //BIRDS




        public ActionResult Add_Birds()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add_Birds(Bird bir, HttpPostedFileBase img)
        {
            if (img.ContentLength > 0)
            {
                //img.SaveAs(Server.MapPath("~/Content/Vimg/" + img.FileName));
                img.SaveAs(Server.MapPath("~/Content/BirdImg/" + img.FileName));
                bir.images = img.FileName;
            }
            db.Birds.Add(bir);
            db.SaveChanges();
            return RedirectToAction("Birds");
        }
        public ActionResult Birds()
        {
            return View(db.Birds.ToList());
        }
        public ActionResult Edit_Birds(int id)
        {
            var edit = db.Birds.Where(a => a.Id == id).FirstOrDefault();

            return View(edit);
        }
        [HttpPost]
        public ActionResult Edit_Birds(Bird bir, HttpPostedFileBase img, int id)
        {
            var edit = db.Birds.Where(a => a.Id == id).FirstOrDefault();
            if (img != null)
            {
                if (img.ContentLength > 0)
                {
                    img.SaveAs(Server.MapPath("~/Content/BirdImg/" + img.FileName));
                    edit.images = img.FileName;
                }

            }
            else
            {
                edit.images = bir.images;
            }
            edit.Title = bir.Title;
            edit.Description = bir.Description;
            db.SaveChanges();
            return RedirectToAction("Birds");
        }
        public ActionResult Delete_Birds(int id)
        {
            var del = db.Birds.Where(a => a.Id == id).FirstOrDefault();
            db.Birds.Remove(del);
            db.SaveChanges();
            return RedirectToAction("Birds");
        }



                                          //Accounts Details






        public ActionResult Account_Detail()
        {
            return View(db.Tables.ToList());
        }

        public ActionResult Add_Account()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Add_Account(Table acc, HttpPostedFileBase img)
        {
            if (img.ContentLength > 0)
            {
                //img.SaveAs(Server.MapPath("~/Content/Vimg/" + img.FileName));
                img.SaveAs(Server.MapPath("~/Content/userimg/" + img.FileName));
                acc.Img = img.FileName;
            }

            db.Tables.Add(acc);
            db.SaveChanges();
            return RedirectToAction("Account_Detail");
        }



        public ActionResult Edit_Account(int id)
        {
            var edit = db.Tables.Where(a => a.Id == id).FirstOrDefault();

            return View(edit);
        }
        [HttpPost]
        public ActionResult Edit_Account(Table acc, HttpPostedFileBase img, int id)
        {
            var edit = db.Tables.Where(a => a.Id == id).FirstOrDefault();
            if (img != null)
            {
                if (img.ContentLength > 0)
                {
                    img.SaveAs(Server.MapPath("~/Content/userimg/" + img.FileName));
                    edit.Img = img.FileName;
                }

            }
            else
            {
                edit.Img = acc.Img;
            }

            edit.FirstName = acc.FirstName;
            edit.LastName = acc.LastName;
            edit.Email = acc.Email;
            edit.Password = acc.Password;
            edit.RoleId = acc.RoleId;

            db.SaveChanges();
            return RedirectToAction("Account_Detail");
        }

        public ActionResult Delete_Account(int id)
        {
            var del = db.Tables.Where(a => a.Id == id).FirstOrDefault();
            db.Tables.Remove(del);
            db.SaveChanges();
            return RedirectToAction("Account_Detail");
        }




        //BOoks

        public ActionResult Add_Books()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add_Books(Book bo, HttpPostedFileBase file , HttpPostedFileBase img)
        {
            if (file.ContentLength > 0 && img.ContentLength > 0)
            {
                //img.SaveAs(Server.MapPath("~/Content/Vimg/" + img.FileName));
                file.SaveAs(Server.MapPath("~/Content/BokImg/" + file.FileName));
                img.SaveAs(Server.MapPath("~/Content/BokImg/" + img.FileName));
                bo.download = file.FileName;
                bo.img = img.FileName;
            }
            db.Books.Add(bo);
            db.SaveChanges();
            return RedirectToAction("Books");
        }
        public ActionResult Books()
        {
            return View(db.Books.ToList());
        }
        public ActionResult Edit_Books(int id)
        {
            var edit = db.Books.Where(a => a.Id == id).FirstOrDefault();

            return View(edit);
        }
        [HttpPost]
        public ActionResult Edit_Books(Book bo, HttpPostedFileBase file, HttpPostedFileBase img, int id)
        {
            var edit = db.Books.Where(a => a.Id == id).FirstOrDefault();
            if (img != null && img != null)
            {
                if (img.ContentLength > 0 && file.ContentLength > 0)
                {
                    file.SaveAs(Server.MapPath("~/Content/BokImg/" + file.FileName));
                    img.SaveAs(Server.MapPath("~/Content/BokImg/" + img.FileName));
                    edit.img = img.FileName;
                    edit.download = file.FileName;

                }

            }
            else
            {
                edit.img = bo.img;
                edit.download = bo.download;

            }
            edit.Title = bo.Title;
            edit.Description = bo.Description;
            db.SaveChanges();
            return RedirectToAction("Books");
        }
        public ActionResult Delete_Books(int id)
        {
            var del = db.Books.Where(a => a.Id == id).FirstOrDefault();
            db.Books.Remove(del);
            db.SaveChanges();
            return RedirectToAction("Books");
        }


        //Edit Specific Account

        public ActionResult Edit(int id)
        {
            var edit = db.Tables.Where(a => a.Id == id).FirstOrDefault();

            return View(edit);
        }
        [HttpPost]
        public ActionResult Edit(Table acc, HttpPostedFileBase img, int id)
        {
            var edit = db.Tables.Where(a => a.Id == id).FirstOrDefault();
            if (img != null)
            {
                if (img.ContentLength > 0)
                {
                    img.SaveAs(Server.MapPath("~/Content/userimg/" + img.FileName));
                    edit.Img = img.FileName;
                }

            }
            else
            {
                edit.Img = acc.Img;
            }

            edit.FirstName = acc.FirstName;
            edit.LastName = acc.LastName;
            edit.Email = acc.Email;
            edit.Password = acc.Password;
            //edit.RoleId = acc.RoleId;

            db.SaveChanges();
            return RedirectToAction("DashBoard");
        }

    }
}