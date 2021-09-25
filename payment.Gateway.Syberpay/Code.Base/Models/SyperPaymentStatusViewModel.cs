using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace payment.Gateway.Syberpay.Code.Base.Models
{
    public class SyperPaymentStatusViewModel
    {
        public string applicationId { get; set; }
        public string transactionId { get; set; }
    }
}
