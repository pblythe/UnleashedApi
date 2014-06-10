using System;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class StockAdjustmentResource : Resource
    {
        public StockAdjustmentResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/StockAdjustments/{page}";
        private const string ByIdUrl = "/StockAdjustments/{id}";

        public Task<IPaginatedList<StockAdjustment>> List(int page = 1, int? pageSize = null, string warehouseCode = null, string productCode = null, string adjustmentType = null, DateTime? adjustmentDate = null)
        {
            return Client.ExecutePagination<StockAdjustment>(ListUrl, page, new { pageSize, warehouseCode, productCode, adjustmentType, adjustmentDate });
        }

        public Task<StockAdjustment> ById(Guid id)
        {
            return Client.ExecuteSingle<StockAdjustment>(ByIdUrl, id);
        }

        public Task Save(StockAdjustment model)
        {
            return Client.ExecutePayload(ByIdUrl, model);
        }
    }
}
