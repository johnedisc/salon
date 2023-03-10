using Microsoft.AspNetCore.Mvc;

namespace PROJECTNAME.Controllers
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
