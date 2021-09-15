using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.Models
{
    public class OrderProduct
    {
        public int OrderProductId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public double Quantity { get; set; }
        public double TotalPriceProducts { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
