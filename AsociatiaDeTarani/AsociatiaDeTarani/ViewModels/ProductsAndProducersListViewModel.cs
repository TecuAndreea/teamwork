using AsociatiaDeTarani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.ViewModels
{
    public class ProductsAndProducersListViewModel
    {
        public IEnumerable<Producer> Producers { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
