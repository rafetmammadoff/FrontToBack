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
            using (StreamReader sr = new StreamReader("C:\\Users\\LENOVO\\Desktop\\FrontToBack\\FrontToBack\\FrontToBack\\Files\\products.json"))
            {
                products = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());
                if (products == null)
                {
                    products = new List<Product>();
                }
            }

            List<Product> products1 = new List<Product>();
            List<Product> products2 = new List<Product>();

            products1 = Top6(products, 6);

            products.Reverse();
            products2 = Top6(products, 4);
            ProductAndLatestPr productAndLatestPr = new ProductAndLatestPr();
            productAndLatestPr.Products = products1;
            productAndLatestPr.LatestProducts = products2;
            return View(productAndLatestPr);
            
        }

        public List<Product> Top6 (List<Product> products,int num)
        {
            List<Product> newProducts=new List<Product>();
            if (num>products.Count)
            {
                num = products.Count;
            }

            for (int i = 0; i < num; i++)
            {
                newProducts.Add(products[i]);
            }
            return newProducts;
        }


        
    }
}
