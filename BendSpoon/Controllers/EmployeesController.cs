using BendSpoon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;
//using System.Linq;

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
      return View();
    }
  }
}