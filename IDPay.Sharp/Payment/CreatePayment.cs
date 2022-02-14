using IDPay.Sharp.Data.Create;
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
    internal class CreatePayment
    {
        public async Task<CreateSuccess> CreatPayment(string SANDBOX, string API_KEY, Create CreationData)
        {
            IRestResponse response = await Task.Run(() =>
            {
                var client = new RestClient("https://api.idpay.ir/v1.1/payment");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("X-API-KEY", API_KEY);
                request.AddHeader("X-SANDBOX", SANDBOX);
                var body = @"{" + "\n" +
                $@"  ""order_id"": {CreationData.order_id}," + "\n" +
                $@"  ""amount"": {CreationData.amount}," + "\n" +
                $@"  ""name"": ""{CreationData.name}""," + "\n" +
                $@"  ""phone"": ""{CreationData.phone}""," + "\n" +
                $@"  ""mail"": ""{CreationData.mail}""," + "\n" +
                $@"  ""desc"": ""{CreationData.desc}""," + "\n" +
                $@"  ""callback"": ""{CreationData.callback}""" + "\n" +
                @"}";
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse resp = client.Execute(request);
                return resp;
            });
            if (response.StatusCode == HttpStatusCode.NotAcceptable|| response.StatusCode == HttpStatusCode.Forbidden|| response.StatusCode == HttpStatusCode.MethodNotAllowed)
            {
                var result = JsonConvert.DeserializeObject<ErrorCode>(response.Content);
                throw new Exception(result.error_message);
            }
            else
            {
                var result = JsonConvert.DeserializeObject<CreateSuccess>(response.Content);
                return await Task.FromResult(result);
            }
        }
    }
}
