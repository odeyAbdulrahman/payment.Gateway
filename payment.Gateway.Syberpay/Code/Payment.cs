using Microsoft.Extensions.Configuration;
using payment.Gateway.Syberpay.Code.Base.Common;
using payment.Gateway.Syberpay.Code.Base.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace payment.Gateway.Syberpay.Code
{
    public class Payment: IPayment
    {
        public Payment(IConfiguration configuration) { Configuration = configuration; }
        private readonly IConfiguration Configuration;
        private static readonly HttpClient Client = new HttpClient();

        public async Task<SyperPaymentResponseViewModel> CheckoutAsync(SyperPaymentViewModel model)
        {
            string Hash = string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", Config().Key, Config().ApplicationId, Config().ServiceId, model.amount.ToString(), Config().Currency, model.customerRef.ToString(), Config().Salt);
            var Values = new Dictionary<string, string> { { "applicationId", Config().ApplicationId }, { "payeeId", Config().PayeeId }, { "serviceId", Config().ServiceId }, { "customerRef", model.customerRef }, { "amount", model.amount.ToString() }, { "currency", Config().Currency }, { "hash", Hash } };
            // Serialize our concrete class into a JSON String
            var stringPayload = await Task.Run(() => JsonHelper.Serialize(Values));
            // Wrap our JSON inside a StringContent which then can be used by the HttpClient class
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
            //var content = new FormUrlEncodedContent(Values);
            var Response = await Client.PostAsync(Config().BaseUtl + "getUrl", httpContent);
            var ResponseString = await Response.Content.ReadAsStringAsync();
            return JsonHelper.Deserialize<SyperPaymentResponseViewModel>(ResponseString);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<SyperPaymentStatusResponseViewModel> StatusAsync(SyperPaymentStatusViewModel model)
        {
            string Hash = string.Format("{0}|{1}|{2}|{3}", Config().Key, Config().ApplicationId, model.transactionId, Config().Salt);
            var Values = new Dictionary<string, string> { { "applicationId", Config().ApplicationId }, { "transactionId", model.transactionId }, { "hash",  Hash} };
            // Serialize our concrete class into a JSON String
            var stringPayload = await Task.Run(() => JsonHelper.Serialize(Values));
            // Wrap our JSON inside a StringContent which then can be used by the HttpClient class
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
            //var content = new FormUrlEncodedContent(Values);
            var Response = await Client.PostAsync(Config().BaseUtl + "payment_status", httpContent);
            var ResponseString = await Response.Content.ReadAsStringAsync();
            return JsonHelper.Deserialize<SyperPaymentStatusResponseViewModel>(ResponseString);
        }

        #region Configuration funcation
        private PaymentConfig Config()
        {
            var Settings = Configuration.GetSection("PaymentConfig");
            return Settings.Get<PaymentConfig>();
        }
        #endregion
    }
}
