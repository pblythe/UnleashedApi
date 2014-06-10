using System;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class StockOnHandResource : Resource
    {
        public StockOnHandResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/StockOnHand/{page}";
        private const string ByIdUrl = "/StockOnHand/{id}";

        public Task<IPaginatedList<StockOnHand>> List(int page = 1, int? pageSize = null, string warehouseCode = null, string warehouseName = null, DateTime? endDate = null)
        {
            return Client.ExecutePagination<StockOnHand>(ListUrl, page, new { pageSize, warehouseCode, warehouseName, endDate });
        }

        public Task<StockOnHand> ById(Guid id)
        {
            return Client.ExecuteSingle<StockOnHand>(ByIdUrl, id);
        }
    }
}
