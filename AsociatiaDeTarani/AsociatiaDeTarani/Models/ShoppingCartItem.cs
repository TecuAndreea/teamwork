using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.Models
{
    public class ShoppingCartItem
    {
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
