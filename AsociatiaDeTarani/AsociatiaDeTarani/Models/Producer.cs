using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.Models
{
    public class Producer
    {
        public int ProducerId { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(50)]
        [RegularExpression("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)",
            ErrorMessage = "Please insert a valid name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        [StringLength(10)]
        [RegularExpression("[0-9]{10}",
        ErrorMessage = "Please insert a valid phone number.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter your delivery cost")]
        public double DeliveryCost { get; set; }
        [Required(ErrorMessage = "Please enter your minimum required order cost")]
        public double MinimumOrder { get; set; }
    }
}
