using System.Collections.Generic;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class TaxResource : Resource
    {
        public TaxResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/Taxes";

        public Task<IList<Tax>> List()
        {
            return Client.ExecuteList<Tax>(ListUrl);
        }
    }
}
