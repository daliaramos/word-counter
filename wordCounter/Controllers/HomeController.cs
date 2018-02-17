using Microsoft.AspNetCore.Mvc;
using wordCounter.Models;

namespace wordCounter.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View("Index");
    }
  }
}
