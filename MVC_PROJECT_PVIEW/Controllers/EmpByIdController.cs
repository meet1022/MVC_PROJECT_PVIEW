using System;
using MVC_PROJECT_PVIEW.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_PROJECT_PVIEW.Controllers
{
    public class EmpByIdController : Controller
    {
        // GET: EmpById
        public ActionResult Index()
        {
            return View();
        }

        // GET: EmpById/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmpById/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: EmpById/Create
        [HttpPost]
        public ActionResult Create(EmployeeSearchModel model)
        {
            try
            {
                // TODO: Add insert logic here
                TempData["EmpCode"] = model.EmpCode;
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpById/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpById/Edit/5
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

        // GET: EmpById/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpById/Delete/5
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
