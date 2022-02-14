using System;
using System.Collections.Generic;
using System.Text;

namespace IDPay.Sharp.Data.Inquiry
{
    public class InquirySuccess
    {
        public int status { get; set; }
        public string track_id { get; set; }
        public string id { get; set; }
        public string order_id { get; set; }
        public string amount { get; set; }
        public Wage wage { get; set; }
        public string date { get; set; }
        public Payer payer { get; set; }
        public Payment payment { get; set; }
        public Verify verify { get; set; }
        public Settlement settlement { get; set; }
    }
    public class Wage
    {
        public string by { get; set; }
        public string type { get; set; }
        public string amount { get; set; }
    }

    public class Payer
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string mail { get; set; }
        public string desc { get; set; }
    }

    public class Payment
    {
        public string track_id { get; set; }
        public string amount { get; set; }
        public string card_no { get; set; }
        public string hashed_card_no { get; set; }
        public string date { get; set; }
    }

    public class Verify
    {
        public string date { get; set; }
    }

    public class Settlement
    {
        public string track_id { get; set; }
        public string amount { get; set; }
        public string date { get; set; }
    }
    public class Inquiry
    {
        /// <summary>
        /// کلید منحصر بفرد تراکنش که در مرحله ایجاد تراکنش دریافت شده است
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// شماره سفارش پذیرنده که در مرحله ایجاد تراکنش ارسال شده است
        /// </summary>
        public string order_id { get; set; }
    }
}
