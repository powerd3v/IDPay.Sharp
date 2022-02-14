using IDPay.Sharp.Payment;
using IDPay.Sharp.Data.Create;
using IDPay.Sharp.Data.Inquiry;
using IDPay.Sharp.Data.Verify;
using System.Threading.Tasks;
using System;

namespace IDPay.Sharp
{
    public class IDClient
    {
        /// <summary>
        /// برای استفاده از ای پی آی های آیدی پی نیاز به یک کلید ای پی آی است. شما می‌توانید به داشبورد خود در آیدی پی رفته و در بخش وب سرویس‌های من، یک وب سرویس جدید ایجاد کنید.
        /// </summary>
        internal string APIKEY { get; set; }
        /// <summary>
        /// برای تست ای پی ای و نحوه کارکرد آن می‌توانید مقدار سند باکس را ترو کنید در حالت معمول فالس است.
        /// </summary>
        internal string SANDBOX { get; set; }
        internal CreatePayment createPayment { get; set; } = new CreatePayment();
        internal InquiryPayment inquiryPayment { get; set; } = new InquiryPayment();
        internal VerifyPayment verifyPayment { get; set; } = new VerifyPayment();
        /// <summary>
        /// جهت استفاده از خدمات ایدی پی یک کلاینت جدید بسازید
        /// </summary>
        /// <param name="api_key">برای استفاده از ای پی آی های آیدی پی نیاز به یک کلید ای پی آی است. شما می‌توانید به داشبورد خود در آیدی پی رفته و در بخش وب سرویس‌های من، یک وب سرویس جدید ایجاد کنید.</param>
        /// <param name="SandBox">برای تست ای پی ای و نحوه کارکرد آن می‌توانید مقدار سند باکس را ترو کنید در حالت معمول فالس است.</param>
        public IDClient(string api_key, bool SandBox = false)
        {
            if (SandBox) SANDBOX = "1"; else SANDBOX = "0";
            APIKEY = api_key;
        }
        /// <summary>
        /// یک تراکنش جدید ایجاد کنید.
        /// </summary>
        /// <param name="order_id">شماره سفارش پذیرنده به حداکثر طول 50 کارکتر</param>
        /// <param name="amount">مبلغ مورد نظر به ریال مبلغ باید بین 1,000 ریال تا 500,000,000 ریال باشد</param>
        /// <param name="name">نام پرداخت کننده به طول حداکثر 255 کاراکتر</param>
        /// <param name="phone">تلفن همراه پرداخت کننده به طول 11 کاراکتر مثل 9382198592 یا 09382198592 یا 989382198592</param>
        /// <param name="mail">پست الکترونیک پرداخت کننده به طول حداکثر 255 کاراکتر</param>
        /// <param name="description">توضیح تراکنش به طول حداکثر 255 کاراکتر</param>
        /// <param name="callback">آدرس بازگشت به سایت پذیرنده به طول حداکثر 2048 کاراکتر</param>
        /// <returns>returns id and Link</returns>
        public async Task<CreateSuccess> Create_Payment(Create CreationData)
        {
            try
            {
                if (CreationData!=null)
                {
                    var result = await createPayment.CreatPayment(SANDBOX, APIKEY, CreationData);
                    return await Task.FromResult(result);
                }
                else
                {
                    throw new Exception("CreationData is null");
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }/// <summary>
         /// دریافت آخرین وضعیت یک تراکنش
         /// </summary>
         /// <param name="QueryData">اطلاعات تراکنش که شامل کلید تراکنش و شماره سفارش است.</param>
         /// <returns></returns>
        public async Task<InquirySuccess> Inquiry_Payment(Inquiry QueryData)
        {
            try
            {
                if (QueryData != null)
                {
                    var result = await inquiryPayment.QueryInPyments(SANDBOX, APIKEY, QueryData);
                    return await Task.FromResult(result);
                }
                else
                {
                    throw new Exception("QueryData is null");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// بعد از دریافت اطلاعات به سایت پذیرنده و اعتبار سنجی اطلاعات توسط پذیرنده، پذیرنده باید تراکنش را تایید کند تا پرداخت بصورت سیستمی تکمیل شود و از بازگشت پول به پرداخت کننده جلوگیری شود.
        /// </summary>
        /// <param name="QueryData">اطلاعات تراکنش که شامل کلید تراکنش و شماره سفارش است.</param>
        /// <returns></returns>
        public async Task<VerifySuccess> Verify_Payment(Inquiry QueryData)
        {
            try
            {
                if (QueryData != null)
                {
                    var result = await verifyPayment.AcceptingTransaction(SANDBOX, APIKEY, QueryData);
                    return await Task.FromResult(result);
                }
                else
                {
                    throw new Exception("QueryData is null");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
