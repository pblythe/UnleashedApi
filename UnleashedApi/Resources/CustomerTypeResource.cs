using System.Collections.Generic;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class CustomerTypeResource : Resource
    {
        public CustomerTypeResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/CustomerTypes";

        public Task<IList<CustomerType>> List()
        {
            return Client.ExecuteList<CustomerType>(ListUrl);
        }
    }
}
