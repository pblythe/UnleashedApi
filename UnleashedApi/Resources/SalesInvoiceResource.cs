using System;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class SalesInvoiceResource : Resource
    {
        public SalesInvoiceResource(IClientExecutionService settings) : base(settings) { }

        private const string ListUrl = "/Invoices/{page}";
        private const string ByIdUrl = "/Invoices/{id}";

        public Task<IPaginatedList<SalesInvoice>> List(int page = 1, int? pageSize = null, string customerCode = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? modifiedSince = null, string orderNumber = null)
        {
            return Client.ExecutePagination<SalesInvoice>(ListUrl, page, new { pageSize, customerCode, startDate, endDate, modifiedSince, orderNumber });
        }

        public Task<SalesInvoice> ById(Guid id)
        {
            return Client.ExecuteSingle<SalesInvoice>(ByIdUrl, id);
        }

        public Task Add(SalesInvoice model)
        {
            return Client.ExecutePayload(ByIdUrl, model);
        }
    }
}
