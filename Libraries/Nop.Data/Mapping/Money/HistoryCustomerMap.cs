using Nop.Core.Domain.Money;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Data.Mapping.Money
{
    public partial class HistoryCustomerMap : NopEntityTypeConfiguration<HistoryCustomer>
    {
        public HistoryCustomerMap()
        {
            this.ToTable("HistoryCustomer");
            this.HasKey(sp => sp.Id);
        }
    }
}
