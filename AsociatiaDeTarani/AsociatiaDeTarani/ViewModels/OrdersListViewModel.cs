using AsociatiaDeTarani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.ViewModels
{
    public class OrdersListViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
    }

}
