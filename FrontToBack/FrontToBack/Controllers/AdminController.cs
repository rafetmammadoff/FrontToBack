using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace FrontToBack.Controllers
{
    public class AdminController : Controller
    {
        private List<Product> products;

        public AdminController()
        {

            using (StreamReader sr =new StreamReader("C:\\Users\\LENOVO\\Desktop\\FrontToBack\\FrontToBack\\FrontToBack\\Files\\products.json"))
            {
                products = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());
                if (products==null)
                {
                    products =new List<Product>();
                }
            }
        }
        

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetProducts()
        {
            return View(products);
        }
        public IActionResult Product()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Product(Product product)
        {
            if (product.NewPrice >= product.OldPrice) return View();

            if (!System.IO.File.Exists("C:\\Users\\LENOVO\\Desktop\\FrontToBack\\FrontToBack\\FrontToBack\\wwwroot\\shop\\img\\" + product.ImgUrl)) return View();

            if (products.Count==0)
            {
                product.Id = 1;
            }
            else
            {
                product.Id = products.FindLast(x => true).Id + 1;
            }
            products.Add(product);
            AddJson();
            return RedirectToAction(nameof(GetProducts));
        }

        public void AddJson()
        {
            
            
            using (StreamWriter sw =new StreamWriter("C:\\Users\\LENOVO\\Desktop\\FrontToBack\\FrontToBack\\FrontToBack\\Files\\products.json"))
            {
                sw.Write(JsonConvert.SerializeObject(products));
            }

        }

        public IActionResult Delete(int id)
        {
            foreach (var item in products)
            {
                if (item.Id == id)
                {
                    products.Remove(item);
                    using (StreamWriter sw = new StreamWriter("C:\\Users\\LENOVO\\Desktop\\FrontToBack\\FrontToBack\\FrontToBack\\Files\\products.json"))
                    {
                        sw.Write(JsonConvert.SerializeObject(products));
                    }
                    return RedirectToAction(nameof(GetProducts));
                }
            }
            return RedirectToAction(nameof(GetProducts));
        }
    }
}
