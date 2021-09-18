using System;
using System.Collections.Generic;
using System.Text;

namespace payment.Gateway.Syberpay.Code.Base.Models
{
    public class PaymentViewModel
    {
        public string status { get; set; }
        public string serviceId { get; set; }
        public double amount { get; set; }
        public string currency { get; set; }
        public string customerRef { get; set; }
        public DateTime tranTimestamp { get; set; }
        public int responseCode { get; set; }
        public string responseMessage { get; set; }
    }
}
