using MVC_PROJECT_PVIEW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_PROJECT_PVIEW.Controllers
{
    public class EmployeeController : Controller
    {
        List<EmployeeModel> emp = new List<EmployeeModel>()
               {
                   new EmployeeModel{EmpCode= "AAA01",FirstName="Martin",LastName="Shalin",DateOfBirth=DateTime.Now,YearsOfExperience=5,Email="marting.shalin@g.com",PhoneNo="9855234317"},
                   new EmployeeModel{EmpCode= "AAA02",FirstName="Max",LastName="Black",DateOfBirth=DateTime.Now,YearsOfExperience=3,Email="max.black@g.com",PhoneNo="9855761317"},
                   new EmployeeModel{EmpCode= "AAA03",FirstName="John",LastName="Bold",DateOfBirth=DateTime.Now,YearsOfExperience=8,Email="John.Bold @g.com",PhoneNo="8755234317"},
                   new EmployeeModel{EmpCode= "AAA04",FirstName="Maya",LastName="Chain",DateOfBirth=DateTime.Now,YearsOfExperience=4,Email="maya.chain @g.com",PhoneNo="9855238327"},
                   new EmployeeModel{EmpCode= "AAA05",FirstName="William",LastName="Shatner",DateOfBirth=DateTime.Now,YearsOfExperience=5,Email="william.shatner @g.com",PhoneNo="9816934317"}

        };

        // GET: Employee
        public ActionResult Index()
        {

            return View();
        }

        // GET: Employee/Details/5
        public ActionResult Details()
        {

            return View(emp);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
