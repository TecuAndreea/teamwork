using AsociatiaDeTarani.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.ViewModels
{
    public class OrderDetailsViewModel
    {
        public int ClientId { get; set; }
        public int OrderId { get; set; }
        [Required(ErrorMessage = "Introduceti numele.")]
        [StringLength(50)]
        [RegularExpression("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)",
            ErrorMessage = "Numele nu este valid, incercati din nou.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Introduceti numarul de telefon.")]
        [StringLength(10)]
        [RegularExpression("[0-9]{10}",
            ErrorMessage = "Numarul de telefon nu este valid, incercati din nou.")]

        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Introduceti adresa")]
        [StringLength(50)]
        public string Adress { get; set; }
        public string PlacementDate { get; set; }
        public string TotalPrice { get; set; }

    }
}
