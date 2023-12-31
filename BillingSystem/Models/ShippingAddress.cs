﻿using System.ComponentModel.DataAnnotations;

namespace BillingSystem.Models
{
    public class ShippingAddress
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        public string Address2 { get; set; }
        [Required]
        public String City { get; set; }
        [Required]
        public String State { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]{10}$")]
        public string ContactNo { get; set; }
    }
}
