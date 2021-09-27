using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.Models
{
    public class Admin
    {
        [Key]
        public int? AdminId { get; set; }
        public string AdminName { get; set; }
        public string DOJ { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
    }
}
