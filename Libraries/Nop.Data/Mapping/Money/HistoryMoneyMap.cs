using Nop.Core.Domain.Money;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Nop.Data.Mapping.Money
{
    public partial class HistoryMoneyMap : NopEntityTypeConfiguration<HistoryMoney>
    {
        public HistoryMoneyMap()
        {
            this.ToTable("HistoryMoney");
            this.HasKey(sp => sp.Id);
        }
    }
}
