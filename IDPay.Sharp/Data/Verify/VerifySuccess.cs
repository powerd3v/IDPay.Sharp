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
    }
}
