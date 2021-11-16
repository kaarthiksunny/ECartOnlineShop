using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.Models
{
    public class ProductTypes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Product Type")]
        public string ProductType { get; set; }
        [Display(Name = "Product Type Image")]
        public string ProductTypeImage { get; set; }
    }
}
