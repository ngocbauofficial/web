using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nop.Web.Models.Customer
{
    public class ResultApiModel
    {
        public int code { get; set; }
        public string msg { get; set; }
        public int info_card { get; set; }

        public int transaction_id { get; set; }

    }

}