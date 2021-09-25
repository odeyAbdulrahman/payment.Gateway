using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using payment.Gateway.Syberpay.Code;
using payment.Gateway.Syberpay.Code.Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SyberPayController : ControllerBase
    {
        private readonly IPayment Payment;
        public SyberPayController(IPayment payment) { Payment = payment; }

        [HttpPost]
        public async Task<ActionResult> PostAsync(SyperPaymentViewModel model)
        {
            try
            {
                var Result = await Payment.CheckoutAsync(model);
                return Ok(Result);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPut]
        public async Task<ActionResult> PutAsync(SyperPaymentStatusViewModel model)
        {
            try
            {
                var Result = await Payment.StatusAsync(model);
                return Ok(Result);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
