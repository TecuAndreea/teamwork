using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.Models
{
    public class JoinOrdersClients
    {
        public int OrderId { get; set; }
        public string ClientName { get; set; }
        public DateTime PlacementDate { get; set; }
        public double TotalPrice { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
        public Client Client { get; set; }


    }
}
