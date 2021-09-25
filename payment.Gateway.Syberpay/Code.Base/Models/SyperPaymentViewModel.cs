using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace payment.Gateway.Syberpay.Code.Base.Models
{
    public class SyperPaymentViewModel
    {
        [Required]
        public string customerRef { get; set; }
        [Required]
        public double amount { get; set; }
    }
}
