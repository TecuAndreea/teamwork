using AsociatiaDeTarani.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.ViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public int ProducerId { get; set; }
        [Required(ErrorMessage = "Introduceti numele produsului")]
        [StringLength(50)]
        [RegularExpression("^([a-zA-Z ]*${2,})",
            ErrorMessage = "Te rog introdu un nume valid")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Introdu pretul produsului")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Introduce-ti imaginea")]
        public IFormFile PhotoUrl { get; set; }
        [Required(ErrorMessage = "Va rog introduceti greutatea in kg a prodosului")]

        public double? Weight { get; set; }
        [Required(ErrorMessage = "Va rog introduceti stocul disponibil al prodosului")]
        public double AvailableStock { get; set; }
        public Producer Producer { get; set; }

    }
}
