using System;
using System.Collections.Generic;
using System.Text;

namespace payment.Gateway.Syberpay.Code.Base.Models
{
    class SyperNotifyViewModel
    {
        public string transactionId { get; set; }
        public string token { get; set; }
        public string hash { get; set; }
    }
}
