using FrontToBack.Models;
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
            return View(products);
            
        }


        //public void CreateProducts()
        //{
        //    Product product1 = new Product()
        //    {
        //        Id = 1,
        //        Name = "Light Wear",
        //        ImgUrl1 = "p24.jpg",
        //        ImgUrl2 = "p25.jpg",
        //        Price = 912
        //    };
        //    Product product2 = new Product()
        //    {
        //        Id = 2,
        //        Name = "Green Wear",
        //        ImgUrl1 = "p24.jpg",
        //        ImgUrl2 = "p25.jpg",
        //        Price = 127
        //    };
        //    Product product3 = new Product()
        //    {
        //        Id = 3,
        //        Name = "Yellow Wear",
        //        ImgUrl1 = "p24.jpg",
        //        ImgUrl2 = "p25.jpg",
        //        Price = 962
        //    };
        //    Product product4 = new Product()
        //    {
        //        Id = 4,
        //        Name = "Black Wear",
        //        ImgUrl1 = "p24.jpg",
        //        ImgUrl2 = "p25.jpg",
        //        Price = 872
        //    };
        //    Product product5 = new Product()
        //    {
        //        Id = 5,
        //        Name = "Gray Wear",
        //        ImgUrl1 = "p24.jpg",
        //        ImgUrl2 = "p25.jpg",
        //        Price = 312
        //    };
        //    Product product6 = new Product()
        //    {
        //        Id = 6,
        //        Name = "Red Wear",
        //        ImgUrl1 = "p24.jpg",
        //        ImgUrl2 = "p25.jpg",
        //        Price = 142
        //    };

        //    List<Product> products = new List<Product>();
        //    products.Add(product1);
        //    products.Add(product2);
        //    products.Add(product3);
        //    products.Add(product4);
        //    products.Add(product5);
        //    products.Add(product6);

        //    using (StreamWriter streamWriter = new StreamWriter("C:\\Users\\LENOVO\\Desktop\\FrontToBack\\FrontToBack\\FrontToBack\\products.json"))
        //    {
        //        streamWriter.Write(JsonConvert.SerializeObject(products));
        //    }
        //}
    }
}
