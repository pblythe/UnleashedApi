using System;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class ProductResource : Resource
    {
        public ProductResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/Products/{page}";
        private const string ByIdUrl = "/Products/{id}";

        public Task<IPaginatedList<Product>> List(int page = 1, int? pageSize = null, string productCode = null, string productDescription = null, string product = null, DateTime? modifiedSince = null, bool? includeObsolete = null)
        {
            return Client.ExecutePagination<Product>(ListUrl, page, new { pageSize, productCode, productDescription, product, modifiedSince, includeObsolete });
        }

        public Task<Product> ById(Guid id)
        {
            return Client.ExecuteSingle<Product>(ByIdUrl, id);
        }

        public Task Save(Product product)
        {
            return Client.ExecutePayload(ByIdUrl, product);
        }
    }
}
