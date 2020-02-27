using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nop.Web.Models.Customer
{
    public partial class NapTheModel
    {

        public int card_type_id { get; set; }
        public int price_guest { get; set; }
        public string pin { get; set; }
        public string seri { get; set; }

        public string note { get; set; }

        public bool security { get; set; }
    }
}