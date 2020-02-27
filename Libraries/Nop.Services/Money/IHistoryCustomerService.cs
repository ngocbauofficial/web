using Nop.Core;
using Nop.Core.Domain.Money;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Services.Money
{
    public partial interface IHistoryCustomerService
    {
        void DeleteHistoryCustomer(HistoryCustomer history);
        HistoryCustomer GetHistoryCustomerById(int Id);


        IList<HistoryCustomer> GetHistoryCustomerByIds(int[] Ids);


        IPagedList<HistoryCustomer> GetAllHistoryCustomer(int pageIndex = 0, int pageSize = int.MaxValue);

        void InsertHistoryCustomer(HistoryCustomer history);


        void UpdateHistoryCustomer(HistoryCustomer history);
    }
}
