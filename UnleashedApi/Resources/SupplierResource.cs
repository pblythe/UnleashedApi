using System;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class SupplierResource : Resource
    {
        public SupplierResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/Suppliers/{page}";
        private const string ByIdUrl = "/Suppliers/{id}";

        public Task<IPaginatedList<Supplier>> List(int page = 1, int? pageSize = null)
        {
            return Client.ExecutePagination<Supplier>(ListUrl, page, new { pageSize });
        }

        public Task<Supplier> ById(Guid id)
        {
            return Client.ExecuteSingle<Supplier>(ByIdUrl, id);
        }

        public Task Save(Supplier model)
        {
            return Client.ExecutePayload(ByIdUrl, model);
        }
    }
}
