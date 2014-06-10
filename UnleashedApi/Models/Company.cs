using System;

namespace UnleashedApi.Models
{
    public class Company : IKey
    {
        public Guid Guid { get; set; }
        public string BaseCurrencyCode { get; set; }
        public string CompanyName { get; set; }
        public decimal? DefaultTaxRate { get; set; }
    }
}
