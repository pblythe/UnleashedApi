using System;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class SalesOrderResource : Resource
    {
        public SalesOrderResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/SalesOrders/{page}";
        private const string ByIdUrl = "/SalesOrders/{id}";

        public Task<IPaginatedList<SalesOrder>> List(int page = 1, int? pageSize = null, string customerCode = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? modifiedSince = null, string orderNumber = null)
        {
            return Client.ExecutePagination<SalesOrder>(ListUrl, page, new { pageSize, customerCode, startDate, endDate, modifiedSince, orderNumber });
        }

        public Task<SalesOrder> ById(Guid id)
        {
            return Client.ExecuteSingle<SalesOrder>(ByIdUrl, id);
        }

        public Task Add(SalesOrder model)
        {
            return Client.ExecutePayload(ByIdUrl, model);
        }
    }
}
