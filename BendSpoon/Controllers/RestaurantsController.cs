using BendSpoon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;
using System.Linq;

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
      return View(_db.Restaurants.OrderBy(restaurant => restaurant.RestName).ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Restaurant thisRestaurant = _db.Restaurants
                                     .FirstOrDefault(restaurant => restaurant.RestaurantId == id);
      return View(thisRestaurant);
    }
  }
}