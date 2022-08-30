using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
