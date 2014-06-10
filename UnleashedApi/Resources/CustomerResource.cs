using System;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class CustomerResource : Resource
    {
        public CustomerResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/Customers/{page}";
        private const string ByIdUrl = "/Customers/{id}";

        public Task<IPaginatedList<Customer>> List(int page = 1, int? pageSize = null, string customerCode = null, string customerName = null, DateTime? modifiedSince = null, bool? includeObsolete = null)
        {
            return Client.ExecutePagination<Customer>(ListUrl, page, new { pageSize, customerCode, customerName, modifiedSince, includeObsolete });
        }

        public Task<Customer> ById(Guid id)
        {
            return Client.ExecuteSingle<Customer>(ByIdUrl, id);
        }

        public Task Save(Customer model)
        {
            return Client.ExecutePayload(ByIdUrl, model);
        }
    }
}
