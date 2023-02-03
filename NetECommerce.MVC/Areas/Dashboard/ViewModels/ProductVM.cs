using NetECommerce.Entity.Entity;
using System.ComponentModel.DataAnnotations;

namespace NetECommerce.MVC.Areas.Dashboard.ViewModels
{
    public class ProductVM
    {
        [Required(ErrorMessage ="Ürün adı pleasee")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Ürün adı pleasee")]
        public decimal UnitPrice { get; set; }

        [Required(ErrorMessage = "Ürün adı pleasee")]
        public short UnitsInStock { get; set; }

        [Required(ErrorMessage = "Ürün adı pleasee")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Ürün adı pleasee")]
        public string? ImagePath { get; set; }

        public Category Category { get; set; }
    }
}
