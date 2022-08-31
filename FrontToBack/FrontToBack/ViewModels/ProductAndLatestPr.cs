using FrontToBack.Models;
using System.Collections.Generic;

namespace FrontToBack.ViewModels
{
    public class ProductAndLatestPr
    {
       public List<Product> Products { get; set; }
       public List<Product> LatestProducts { get; set; }
    }
}
