using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Money
{
    public partial class HistoryCustomer : BaseEntity
    {
        public int CustomerId { get; set; }
        public decimal Money { get; set; }
        public int OrderId { get; set; }
         public DateTime CreatedOnUtc { get; set; }
    }
}
