using Nop.Core;
using Nop.Core.Data;
using Nop.Core.Domain.Money;
using Nop.Services.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Nop.Services.Money
{
    public partial class HistoryMoneyService :IHistoryMoneyService
    {
        private readonly IRepository<HistoryMoney> _historyMoneyRepository;
        private readonly IEventPublisher _eventPublisher;
        public HistoryMoneyService(IRepository<HistoryMoney> historyMoneyRepository, 
            IEventPublisher eventPublisher)
        {
            this._historyMoneyRepository = historyMoneyRepository;
            this._eventPublisher = eventPublisher;
        }

        public virtual void DeleteHistoryMoney(HistoryMoney historymoney)
        {
            if (historymoney == null)
                throw new ArgumentNullException("historymoney");

            _historyMoneyRepository.Delete(historymoney);

            //event notification
            _eventPublisher.EntityDeleted(historymoney);
        }

        /// <summary>
        /// Gets a news
        /// </summary>
      
        /// <returns>News</returns>
        public virtual HistoryMoney GetHistoryMoneyById(int Id)
        {
            if (Id == 0)
                return null;

            return _historyMoneyRepository.GetById(Id);
        }

        /// <summary>
        /// Gets news
        /// </summary>
   
        /// <returns>News</returns>
        public virtual IList<HistoryMoney> GetHistoryMoneyByIds(int[] Ids)
        {
            var query = _historyMoneyRepository.Table;
            return query.Where(p => Ids.Contains(p.Id)).ToList();
        }

        /// <summary>
        /// Gets all news
        /// </summary>
        /// <param name="languageId">Language identifier; 0 if you want to get all records</param>
        /// <param name="storeId">Store identifier; 0 if you want to get all records</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="showHidden">A value indicating whether to show hidden records</param>
        /// <returns>News items</returns>
        public virtual IPagedList<HistoryMoney> GetAllHistoryMoney (int pageIndex = 0, int pageSize = int.MaxValue)
        {
       
            //Store mapping
            var query = from a in _historyMoneyRepository.Table select a;
            var item = new PagedList<HistoryMoney>(query, pageIndex, pageSize);
            return item;
        }

        /// <summary>
        /// Inserts a news item
        /// </summary>

        public virtual void InsertHistoryMoney(HistoryMoney history)
        {
            if (history == null)
                throw new ArgumentNullException("history");

            _historyMoneyRepository.Insert(history);

            //event notification
            _eventPublisher.EntityInserted(history);
        }

        /// <summary>
        /// Updates the news item
        /// </summary>
        /// <param name="news">News item</param>
        public virtual void UpdateHistoryMoney(HistoryMoney history)
        {
            if (history == null)
                throw new ArgumentNullException("history");

            _historyMoneyRepository.Update(history);

            //event notification
            _eventPublisher.EntityUpdated(history);
        }
        
    }
}
