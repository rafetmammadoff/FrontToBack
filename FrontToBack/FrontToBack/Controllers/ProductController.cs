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

        //public void CreateProducts()
        //{
        //    Product product1 = new Product()
        //    {
        //        Id = 1,
        //        Name = "Fushion-Top",
        //        ImgUrl1 = "p36.jpg",
        //        ImgUrl2 = "p36.jpg",
        //        Price = 12
        //    };
        //    Product product2 = new Product()
        //    {
        //        Id = 2,
        //        Name = "Fushion-Top",
        //        ImgUrl1 = "p36.jpg",
        //        ImgUrl2 = "p36.jpg",
        //        Price = 17
        //    };
        //    Product product3 = new Product()
        //    {
        //        Id = 3,
        //        Name = "Fushion-Top",
        //        ImgUrl1 = "p36.jpg",
        //        ImgUrl2 = "p36.jpg",
        //        Price = 162
        //    };
        //    Product product4 = new Product()
        //    {
        //        Id = 4,
        //        Name = "Fushion-Top",
        //        ImgUrl1 = "p36.jpg",
        //        ImgUrl2 = "p36.jpg",
        //        Price = 872
        //    };
        //    Product product5 = new Product()
        //    {
        //        Id = 5,
        //        Name = "Fushion-Top",
        //        ImgUrl1 = "p36.jpg",
        //        ImgUrl2 = "p36.jpg",
        //        Price = 562
        //    };
        //    Product product6 = new Product()
        //    {
        //        Id = 6,
        //        Name = "Fushion-Top",
        //        ImgUrl1 = "p36.jpg",
        //        ImgUrl2 = "p36.jpg",
        //        Price = 987
        //    };
        //    Product product7 = new Product()
        //    {
        //        Id = 6,
        //        Name = "Fushion-Top",
        //        ImgUrl1 = "p36.jpg",
        //        ImgUrl2 = "p36.jpg",
        //        Price = 987
        //    };
        //    Product product8 = new Product()
        //    {
        //        Id = 6,
        //        Name = "Fushion-Top",
        //        ImgUrl1 = "p36.jpg",
        //        ImgUrl2 = "p36.jpg",
        //        Price = 987
        //    };
        //    Product product9 = new Product()
        //    {
        //        Id = 6,
        //        Name = "Fushion-Top",
        //        ImgUrl1 = "p36.jpg",
        //        ImgUrl2 = "p36.jpg",
        //        Price = 987
        //    };

        //    List<Product> products = new List<Product>();
        //    products.Add(product1);
        //    products.Add(product2);
        //    products.Add(product3);
        //    products.Add(product4);
        //    products.Add(product5);
        //    products.Add(product6);
        //    products.Add(product7);
        //    products.Add(product8);
        //    products.Add(product9);

        //    using (StreamWriter sw = new StreamWriter("C:\\Users\\LENOVO\\Desktop\\FrontToBack\\FrontToBack\\FrontToBack\\ListiningProducts.json"))
        //    {
        //        sw.Write(JsonConvert.SerializeObject(products));
        //    }
        //}
    }
}
