using System.Collections.Generic;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class ProductGroupResource : Resource
    {
        public ProductGroupResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/ProductGroups";

        public Task<IList<ProductGroup>> List()
        {
            return Client.ExecuteList<ProductGroup>(ListUrl);
        }
    }
}
