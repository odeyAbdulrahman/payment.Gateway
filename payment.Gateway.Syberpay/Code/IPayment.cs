using payment.Gateway.Syberpay.Code.Base.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace payment.Gateway.Syberpay.Code
{
    public interface IPayment
    {
        Task<SyperPaymentResponseViewModel> CheckoutAsync(SyperPaymentViewModel model);
        Task<SyperPaymentStatusResponseViewModel> StatusAsync(SyperPaymentStatusViewModel model);
    }
}
