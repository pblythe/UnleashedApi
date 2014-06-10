using System.Collections.Generic;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class BillOfMaterialResource : Resource
    {
        public BillOfMaterialResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/BillOfMaterials";

        public Task<IList<BillOfMaterial>> List()
        {
            return Client.ExecuteList<BillOfMaterial>(ListUrl);
        }
    }
}
