using DotNet_MVC_EntityFramework.Models;
using DotNet_MVC_EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNet_MVC_EntityFramework.Controllers
{
    public class DepartmentController : Controller
    {
        IRepository<Department> depRepo = new DepartmentRepository();
        // GET: Department
        public ActionResult Index()
        {
            return View(depRepo.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department dept)
        {
            depRepo.Create(dept);
            return RedirectToAction("Details", new { id = dept.DepartmentId });
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(depRepo.Get(id));
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(depRepo.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(Department dep)
        {
            depRepo.Update(dep);
            return RedirectToAction("Details", new { id = dep.DepartmentId });
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(depRepo.Get(id));
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            depRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}