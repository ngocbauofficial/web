using Nop.Core;
using Nop.Core.Domain.Money;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Services.Money
{
    public partial interface IHistoryMoneyService
    {
        void DeleteHistoryMoney(HistoryMoney historymoney);
        HistoryMoney GetHistoryMoneyById(int Id);

  
        IList<HistoryMoney> GetHistoryMoneyByIds(int[] Ids);


        IPagedList<HistoryMoney> GetAllHistoryMoney(int pageIndex = 0, int pageSize = int.MaxValue);

        void InsertHistoryMoney(HistoryMoney historymoney);

    
        void UpdateHistoryMoney(HistoryMoney historymoney);

    }
}
