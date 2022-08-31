namespace FrontToBack.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SubTitle { get; set; }
        public double OldPrice { get; set; }
        public double NewPrice { get; set; }
        public string ImgUrl { get; set; }
    }
}
