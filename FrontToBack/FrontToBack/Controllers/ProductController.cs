using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

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
