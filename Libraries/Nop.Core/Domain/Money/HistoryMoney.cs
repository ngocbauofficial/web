using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Money
{
  public partial  class HistoryMoney : BaseEntity
    {
           public string Seri { get; set; }
           public string Pin { get; set; }
           public decimal Price_guest { get; set; }
           public int CustomerId { get; set; }
           public bool Status { get; set; }
           public DateTime CreatedOnUtc { get; set; }
    }
}
