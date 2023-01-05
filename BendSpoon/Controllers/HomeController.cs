using BendSpoon.Models;
using Microsoft.AspNetCore.Mvc;

namespace BendSpoon.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}