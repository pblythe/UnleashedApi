using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class DeliveryMethodResource : Resource
    {
        public DeliveryMethodResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/DeliveryMethods";

        public Task<IPaginatedList<DeliveryMethod>> List(int page = 0, int? pageSize = null)
        {
            return Client.ExecutePagination<DeliveryMethod>(ListUrl, page, new { pageSize });
        }
    }
}
