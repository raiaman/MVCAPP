using MyFirstWebApp.Models;
using MyFirstWebApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        readonly EmpRepository empRepository;
        public EmployeeController(EmpRepository _empRepository)
        {
            this.empRepository = _empRepository;
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllEmpDetails()
        {
            return View(empRepository.GetAllEmployees());
        }

        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(EmpModel Emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (empRepository.AddEmployee(Emp))
                    {
                        ViewBag.Message = "Employee details added successfully";
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult EditEmpDetails(int id)
        {
            return View(empRepository.GetAllEmployees().Find(Emp=>Emp.Empid==id));
        }

        [HttpPost]
        public ActionResult EditEmpDetails(int id, EmpModel obj)
        {
            try
            {
                empRepository.UpdateEmployee(obj);
                return RedirectToAction("GetAllEmpDetails");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DeleteEmp(int id)
        {
            empRepository.DeleteEmployee(id);
            return RedirectToAction("GetAllEmpDetails");
        }
    }
}