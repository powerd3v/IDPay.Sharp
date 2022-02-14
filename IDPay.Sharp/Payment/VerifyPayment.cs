using IDPay.Sharp.Data.Inquiry;
using IDPay.Sharp.Data.Verify;
using IDPay.Sharp.Exceptions;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IDPay.Sharp.Payment
{
    internal class VerifyPayment
    {
        public async Task<VerifySuccess> AcceptingTransaction(string SANDBOX, string API_KEY, Inquiry Query)
        {
            IRestResponse response = await Task.Run(() =>
            {
                var client = new RestClient("https://api.idpay.ir/v1.1/payment/verify");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("X-API-KEY", API_KEY);
                request.AddHeader("X-SANDBOX", SANDBOX);
                var body = @"{" + "\n" +
                $@"  ""id"": ""{Query.id}""," + "\n" +
                $@"  ""order_id"": ""{Query.order_id}""" + "\n" +
                @"}";
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse resp = client.Execute(request);
                return resp;
            });
            if (response.StatusCode == HttpStatusCode.NotAcceptable || response.StatusCode == HttpStatusCode.Forbidden || response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.MethodNotAllowed)
            {
                var result = JsonConvert.DeserializeObject<ErrorCode>(response.Content);
                throw new Exception(result.error_message);
            }
            else
            {
                var result = JsonConvert.DeserializeObject<VerifySuccess>(response.Content);
                return await Task.FromResult(result);
            }
        }
    }
}
