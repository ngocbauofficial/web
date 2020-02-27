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
    public partial class HistoryCustomerService : IHistoryCustomerService
    {
        private readonly IRepository<HistoryCustomer> _historyCustomerRepository;
        private readonly IEventPublisher _eventPublisher;
        public HistoryCustomerService(IRepository<HistoryCustomer> historyCustomerRepository,
            IEventPublisher eventPublisher)
        {
            this._historyCustomerRepository = historyCustomerRepository;
            this._eventPublisher = eventPublisher;
        }

        public virtual void DeleteHistoryCustomer(HistoryCustomer historyCustomer)
        {
            if (historyCustomer == null)
                throw new ArgumentNullException("historyCustomer");

            _historyCustomerRepository.Delete(historyCustomer);

            //event notification
            _eventPublisher.EntityDeleted(historyCustomer);
        }

        /// <summary>
        /// Gets a news
        /// </summary>

        /// <returns>News</returns>
        public virtual HistoryCustomer GetHistoryCustomerById(int Id)
        {
            if (Id == 0)
                return null;

            return _historyCustomerRepository.GetById(Id);
        }

        /// <summary>
        /// Gets news
        /// </summary>

        /// <returns>News</returns>
        public virtual IList<HistoryCustomer> GetHistoryCustomerByIds(int[] Ids)
        {
            var query = _historyCustomerRepository.Table;
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
        public virtual IPagedList<HistoryCustomer> GetAllHistoryCustomer(int pageIndex = 0, int pageSize = int.MaxValue)
        {

            //Store mapping
            var query = from a in _historyCustomerRepository.Table select a;
            var item = new PagedList<HistoryCustomer>(query, pageIndex, pageSize);
            return item;
        }

        /// <summary>
        /// Inserts a news item
        /// </summary>

        public virtual void InsertHistoryCustomer(HistoryCustomer history)
        {
            if (history == null)
                throw new ArgumentNullException("history");

            _historyCustomerRepository.Insert(history);

            //event notification
            _eventPublisher.EntityInserted(history);
        }

        /// <summary>
        /// Updates the news item
        /// </summary>
        /// <param name="news">News item</param>
        public virtual void UpdateHistoryCustomer(HistoryCustomer history)
        {
            if (history == null)
                throw new ArgumentNullException("history");

            _historyCustomerRepository.Update(history);

            //event notification
            _eventPublisher.EntityUpdated(history);
        }
    }  
}
