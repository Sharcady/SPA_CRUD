using SPA_CRUD.DAL.Contexts;
using SPA_CRUD.DAL.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPA_CRUD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new ViewModel();
            using (var db = new UserContext())
            {
                model.Users = db.Users.ToList();
            }
            using (var db = new DepartmentContext())
            {
                model.Departments = db.Departments.ToList();
            }
            
            return View(model);
        }

        public ActionResult Add(string username, string department)
        {
            try
            {

                using (var users = new UserContext())
                {
                    using (var departments = new DepartmentContext())
                    {
                        var dep = departments.Departments.First(d => d.Title == department);

                        var user = new User()
                        {
                            DepartmentId = dep.Id,
                            UserName = username
                        };

                        users.Users.Add(user);
                        users.SaveChanges();
                    }
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public ActionResult Edit(int id)
        {
            using(var db = new UserContext())
            {
                var record =  db.Users.Where(u => u.Id == id);

            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            try
            {
                using(var db = new UserContext())
                {
                    var record = db.Users.FirstOrDefault(u => u.Id == id);
                    if (record != null)
                    {
                        db.Users.Remove(record);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return RedirectToAction("Index");
        }
    }
}
