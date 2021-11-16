using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECartOnlineShop.Models
{
    public class Login
    {
        public string AdminName { get; set; }
        public string Password { get; set; }
    }

    public class CustomerLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
