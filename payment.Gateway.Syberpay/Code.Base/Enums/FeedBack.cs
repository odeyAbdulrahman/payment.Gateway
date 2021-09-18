using System;
using System.Collections.Generic;
using System.Text;

namespace payment.Gateway.Syberpay.Code.Base.Enums
{
    class FeedBack
    {
        public enum SyperFeedBack : int
        {
            SyperPaymentApproved = 0,
            SyperApproved = 1,
            SyperInvalidTransaction = 2,
            SyperInvalidServiceId = 3,
            SyperInvalidRequestFormat = 4,
            SyperInvalidpaymentInformation = 5,
            SyperSystemError = 6,
            SyperInvalidCustomerReference = 7,
            SyperInvalidPayee = 8,
            SyperInvalidApplication = 9,
            SyperAuthenticationFailed = 10,
            SyperConnectionFailed = 11,
            SyperConnectionTimedOut = 12,
            SyperInvalidInputEntry = 13,
            SyperInvalidTransactionId = 14
        }
    }
}
