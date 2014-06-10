using System.Collections.Generic;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class CustomerDeliveryAddressResource : Resource
    {
        public CustomerDeliveryAddressResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/CustomerDeliveryAddresses";

        public Task<IList<CustomerAddress>> List()
        {
            return Client.ExecuteList<CustomerAddress>(ListUrl);
        }
    }
}
