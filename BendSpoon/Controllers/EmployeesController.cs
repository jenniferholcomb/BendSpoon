using BendSpoon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;
using System.Linq;

namespace BendSpoon.Controllers
{
  public class EmployeesController : Controller
  {
    private readonly BendSpoonContext _db;

    public EmployeesController(BendSpoonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Employees.OrderBy(employee => employee.Name).ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Employee employee)
    {
      _db.Employees.Add(employee);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Employee thisEmployee = _db.Employees.FirstOrDefault(employee => employee.EmployeeId == id);
      return View(thisEmployee);
    }
  }
}