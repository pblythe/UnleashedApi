using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class WarehouseStockTransferResource : Resource
    {
        public WarehouseStockTransferResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/WarehouseStockTransfer";
        private const string ByIdUrl = "/WarehouseStockTransfer/{id}";

        public Task<IList<WarehouseStockTransfer>> List()
        {
            return Client.ExecuteList<WarehouseStockTransfer>(ListUrl);
        }

        public Task<WarehouseStockTransfer> ById(Guid id)
        {
            return Client.ExecuteSingle<WarehouseStockTransfer>(ByIdUrl, id);
        }
    }
}
