using System.Collections.Generic;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class PaymentTermResource : Resource
    {
        public PaymentTermResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/PaymentTerms";

        public Task<IList<PaymentTerm>> List()
        {
            return Client.ExecuteList<PaymentTerm>(ListUrl);
        }
    }
}
