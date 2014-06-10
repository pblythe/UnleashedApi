using System;

namespace UnleashedApi.Models
{
    public class Tax : IKey
    {
        public Guid Guid { get; set; }
        public string Description { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string TaxCode { get; set; }
        public decimal TaxRate { get; set; }
    }
}
