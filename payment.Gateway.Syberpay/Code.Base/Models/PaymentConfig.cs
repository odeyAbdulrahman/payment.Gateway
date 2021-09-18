using System;
using System.Collections.Generic;
using System.Text;

namespace payment.Gateway.Syberpay.Code.Base.Models
{
    public class PaymentConfig
    {
        public string BaseUtl { set; get; }
        public string ApplicationId { set; get; }
        public string ServiceId { set; get; }
        public string Key { set; get; }
        public string Salt { set; get; }
        public string PayeeId { set; get; }
        public string Currency { set; get; }
    }
}
