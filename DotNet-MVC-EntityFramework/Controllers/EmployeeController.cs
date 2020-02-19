using DotNet_MVC_EntityFramework.Models;
using DotNet_MVC_EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNet_MVC_EntityFramework.Controllers
{
    public class EmployeeController : Controller
    {
        IRepository<Employee> emRepo = new EmployeeRepository();
        // GET: Employee
        public ActionResult Index()
        {
            return View(emRepo.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            emRepo.Create(emp);
            return RedirectToAction("Details", new { id = emp.EmployeeId});
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(emRepo.Get(id));
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(emRepo.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            emRepo.Update(emp);
            return RedirectToAction("Details", new { id = emp.EmployeeId });
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(emRepo.Get(id));
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            emRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}