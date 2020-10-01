using System;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class SalesShipmentResource : Resource
    {
        public SalesShipmentResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/SalesShipments/{page}";
        private const string ByIdUrl = "/SalesShipments/{id}";

        public Task<IPaginatedList<SalesShipment>> List(int page = 1, int? pageSize = null, string shippingStatus = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? modifiedSince = null, string orderNumber = null)
        {
            return Client.ExecutePagination<SalesShipment>(ListUrl, page, new { pageSize, shippingStatus, startDate, endDate, modifiedSince, orderNumber });
        }

        public Task<SalesShipment> ById(Guid id)
        {
            return Client.ExecuteSingle<SalesShipment>(ByIdUrl, id);
        }
    }
}
