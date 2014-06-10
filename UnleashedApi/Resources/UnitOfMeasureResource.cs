using System.Collections.Generic;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class UnitOfMeasureResource : Resource
    {
        public UnitOfMeasureResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/UnitOfMeasures";

        public Task<IList<UnitOfMeasure>> List()
        {
            return Client.ExecuteList<UnitOfMeasure>(ListUrl);
        }
    }
}
