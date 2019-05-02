using Microsoft.AspNetCore.Mvc;

namespace HangMan.Controllers
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
