using System;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class SalesPersonResource : Resource
    {
        public SalesPersonResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/Salespersons/{page}";
        private const string ByIdUrl = "/Salespersons/{id}";

        public Task<IPaginatedList<SalesPerson>> List(int page = 1, int? pageSize = null)
        {
            return Client.ExecutePagination<SalesPerson>(ListUrl, page, new { pageSize });
        }

        public Task<SalesPerson> ById(Guid id)
        {
            return Client.ExecuteSingle<SalesPerson>(ByIdUrl, id);
        }

        public Task Save(SalesPerson model)
        {
            return Client.ExecutePayload(ByIdUrl, model);
        }
    }
}
