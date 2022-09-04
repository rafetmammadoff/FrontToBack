using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _sql;
        public HomeController(Context sql)
        {
            _sql = sql;
        }

        public IActionResult Index()
        {
            ProductAndLatestPr productAndLatestPr = new ProductAndLatestPr();
            productAndLatestPr.Products = _sql.Products.Take(6).ToList();
            productAndLatestPr.LatestProducts = _sql.Products.OrderByDescending(x=>x.Id).Take(4).ToList();
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
