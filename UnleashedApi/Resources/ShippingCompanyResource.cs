using System.Collections.Generic;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class ShippingCompanyResource : Resource
    {
        public ShippingCompanyResource(IClientExecutionService client) : base(client) {}

        private const string ListUrl = "/ShippingCompanies";

        public Task<IList<ShippingCompany>> List(bool? includeObsolete = null)
        {
            return Client.ExecuteList<ShippingCompany>(ListUrl, new { includeObsolete });
        }
    }
}