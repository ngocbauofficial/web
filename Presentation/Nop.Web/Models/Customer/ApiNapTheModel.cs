using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nop.Web.Models.Customer
{
    public partial class ApiNapTheModel
    {
        public int merchant_id { get; set; }
        public string api_user { get; set; }
        public string api_password { get; set; }
        public string pin { get; set; }
        public string seri { get; set; }
        public int price_guest { get; set; }
        public int card_type { get; set; }
        public string note { get; set; }
    }
}