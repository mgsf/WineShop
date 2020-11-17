using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Models
{
    public class Wine
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100,ErrorMessage = "Wine name too long")]
        public string Name { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Wine Country too long")]
        public string Country { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
        [StringLength(20)]
        public string Year { get; set; }
        [StringLength(20)]
        public string Age { get; set; }
        [StringLength(50)]
        public string Varietal { get; set; }
        [StringLength(20)]
        public string Size { get; set; }
        public double Price { get; set; }
        [StringLength(250, ErrorMessage = "Image URL too long")]
        public string Image { get; set; }

    }
}
