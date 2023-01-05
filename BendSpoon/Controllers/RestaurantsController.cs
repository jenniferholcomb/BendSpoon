using BendSpoon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;
//using System.Linq;

namespace BendSpoon.Controllers
{
  public class RestaurantsController : Controller
  {
    private readonly BendSpoonContext _db;

    public RestaurantsController(BendSpoonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }
  }
}