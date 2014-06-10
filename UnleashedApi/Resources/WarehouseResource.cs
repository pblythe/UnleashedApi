using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class WarehouseResource : Resource
    {
        public WarehouseResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/Warehouses";

        public Task<IPaginatedList<Warehouse>> List(int page = 1, int? pageSize = null)
        {
            return Client.ExecutePagination<Warehouse>(ListUrl, page, new { pageSize });
        }
    }
}
