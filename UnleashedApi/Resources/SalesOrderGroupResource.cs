using System.Collections.Generic;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class SalesOrderGroupResource : Resource
    {
        public SalesOrderGroupResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/SalesOrderGroups";

        public Task<IList<SalesOrderGroup>> List()
        {
            return Client.ExecuteList<SalesOrderGroup>(ListUrl);
        }
    }
}
