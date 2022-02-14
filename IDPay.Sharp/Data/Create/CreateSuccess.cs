using System;
using System.Collections.Generic;
using System.Text;

namespace IDPay.Sharp.Data.Create
{
    public class CreateSuccess
    {
        public string id { get; set; }
        public string link { get; set; }
    }
    public class Create
    {
        /// <summary>
        /// این بخش ضرروری است
        /// </summary>
        public int order_id { get; set; }
        /// <summary>
        /// این بخش ضرروری است
        /// </summary>
        public int amount { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string mail { get; set; }
        public string desc { get; set; }
        public string callback { get; set; }
    }
}
