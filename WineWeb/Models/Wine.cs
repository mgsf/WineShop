using System;
namespace WineWeb.Models
{
    public class Wine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
        public string Age { get; set; }
        public string Varietal { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

    }
}
