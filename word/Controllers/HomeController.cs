using Microsoft.AspNetCore.Mvc;
using word.Models;

namespace word.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View("Index");
    }

    [HttpPost("/Results")]
    public ActionResult Results()
    {
      wordCounter wordcounter = new wordCounter(Request.Form["word"], Request.Form["sentence"]
      );
      int num = wordcounter.addWord();
      return View("Results", wordcounter);
    }
  }
}
