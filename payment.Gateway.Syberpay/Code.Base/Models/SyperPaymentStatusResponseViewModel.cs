using System;
using System.Collections.Generic;
using System.Text;

namespace payment.Gateway.Syberpay.Code.Base.Models
{
    public class SyperPaymentStatusResponseViewModel
    {
        public string applicationId { get; set; }
        public string transactionId { get; set; }
        public DateTime tranTimestamp { get; set; }
        public int responseCode { get; set; }
        public string responseMessage { get; set; }
        public PaymentViewModel payment { get; set; }
        public string status { get; set; }
    }
}
