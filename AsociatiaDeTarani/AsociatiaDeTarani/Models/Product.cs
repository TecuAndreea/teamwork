using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ProducerId { get; set; }
        [Required(ErrorMessage = "Please enter product name")]
        [StringLength(50)]
        [RegularExpression("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)",
            ErrorMessage = "Please insert a valid product name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your product price")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Please enter a valid URL")]
        public string PhotoUrl { get; set; }
        public double? Weight { get; set; }
        [Required(ErrorMessage = "Please enter your available stock")]
        public double AvailableStock { get; set; }
        public Producer Producer { get; set; }

    }
}
