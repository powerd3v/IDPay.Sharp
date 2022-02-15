using System;
using System.Collections.Generic;
using System.Text;

namespace IDPay.Sharp.Data.Verify
{
    public class VerifySuccess
    {
        public int status { get; set; }
        public string track_id { get; set; }
        public string id { get; set; }
        public string order_id { get; set; }
        public string amount { get; set; }
        public string date { get; set; }
        public Inquiry.Payment payment { get; set; }
        public Inquiry.Verify verify { get; set; }
        public override string ToString()
        {
            string Status = "";
            switch (status)
            {
                case 1:
                    Status = "پرداخت انجام نشده است";
                    break;
                case 2:
                    Status = "پرداخت ناموفق بوده است";
                    break;
                case 3:
                    Status = "خطا رخ داده است";
                    break;
                case 4:
                    Status = "بلوکه شده";
                    break;
                case 5:
                    Status = "برگشت به پرداخت کننده";
                    break;
                case 6:
                    Status = "برگشت خورده سیستمی";
                    break;
                case 7:
                    Status = "انصراف از پرداخت";
                    break;
                case 8:
                    Status = "به درگاه پرداخت منتقل شد";
                    break;
                case 10:
                    Status = "در انتظار تایید پرداخت";
                    break;
                case 100:
                    Status = "پرداخت تایید شده است";
                    break;
                case 101:
                    Status = "پرداخت قبلا تایید شده است";
                    break;
                case 200:
                    Status = "به دریافت کننده واریز شد";
                    break;
                default:
                    break;
            }
            return $"Status : {Status}\r\n" +
                $"Track ID : {track_id}\r\n" +
                $"ID : {id}\r\n" +
                $"Order ID : {order_id}\r\n" +
                $"Amount : {amount}\r\n" +
                $"Date : {date}\r\n" +
                $"Payment Amount : {payment.amount}\r\n" +
                $"Payment Card Number : {payment.card_no}\r\n" +
                $"Payment Date : {payment.date}\r\n" +
                $"Payment Card Hash : {payment.hashed_card_no}\r\n" +
                $"Payment Track ID : {payment.track_id}\r\n" +
                $"Verify Date : {verify.date}";
        }
    }
}
