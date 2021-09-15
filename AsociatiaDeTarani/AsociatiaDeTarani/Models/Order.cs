using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public DateTime PlacementDate { get; set; }
        public double TotalPrice { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
        public Client Client { get; set; }


    }
}
