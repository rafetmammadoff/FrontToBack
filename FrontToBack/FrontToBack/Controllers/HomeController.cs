using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            using (StreamReader streamReader = new StreamReader("C:\\Users\\LENOVO\\Desktop\\FrontToBack\\FrontToBack\\FrontToBack\\products.json"))
            {
                products = JsonConvert.DeserializeObject<List<Product>>(streamReader.ReadToEnd());
            }

            List<Product> latestArriwalProd = new List<Product>();

            using (StreamReader sr = new StreamReader("C:\\Users\\LENOVO\\Desktop\\FrontToBack\\FrontToBack\\FrontToBack\\latestArrivalProducts.json"))
            {
                latestArriwalProd = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());
            };
            ProductAndLatestArrivalProduct productAndLatestArrivalProduct = new ProductAndLatestArrivalProduct();
            productAndLatestArrivalProduct.Products = products;
            productAndLatestArrivalProduct.LatestArrivalProducts = latestArriwalProd;
            return View(productAndLatestArrivalProduct);
            
        }


        
    }
}
