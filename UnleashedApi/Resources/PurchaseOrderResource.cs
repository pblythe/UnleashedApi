using System;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class PurchaseOrderResource : Resource
    {
        public PurchaseOrderResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/PurchaseOrders/{page}";
        private const string ByIdUrl = "/PurchaseOrders/{id}";

        public Task<IPaginatedList<PurchaseOrder>> List(int page = 1, int? pageSize = null, string supplierCode = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            return Client.ExecutePagination<PurchaseOrder>(ListUrl, page, new { pageSize, supplierCode, startDate, endDate });
        }

        public Task<PurchaseOrder> ById(Guid id)
        {
            return Client.ExecuteSingle<PurchaseOrder>(ByIdUrl, id);
        }

        public Task Add(PurchaseOrder model)
        {
            return Client.ExecutePayload(ByIdUrl, model);
        }
    }
}
