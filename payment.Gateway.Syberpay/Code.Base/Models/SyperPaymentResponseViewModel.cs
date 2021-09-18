using System;
using System.Collections.Generic;
using System.Text;

namespace payment.Gateway.Syberpay.Code.Base.Models
{
    public class SyperPaymentResponseViewModel
    {
        public string applicationId { get; set; }
        public string payeeId { get; set; }
        public string serviceId { get; set; }
        public double amount { get; set; }
        public string currency { get; set; }
        public int paymentInfo { get; set; }
        public int customerRef { get; set; }
        public DateTime tranTimestamp { get; set; }
        public int responseCode { get; set; }
        public string responseMessage { get; set; }
        public string paymentUrl { get; set; }
        public string transactionId { get; set; }
    }
}
