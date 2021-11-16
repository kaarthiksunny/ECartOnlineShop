using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Product Price")]
        public Decimal ProductPrice { get; set; }
        [Display(Name = "Product Description")]
        public string ProductDescription { get; set; }
        [Display(Name = "Product Rating")]
        public string ProductRating { get; set; }
        [Display(Name = "Product Image")]
        public string ProductImage { get; set; }
        //[Required]
        //[Display(Name = "Available")]
       // public bool IsAvailable { get; set; }
        [Display(Name = "Product Type")]
        public string ProductCategory { get; set; }
        public int ProductCategoryId { get; set; }

    }
}
