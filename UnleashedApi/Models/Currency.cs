using System;

namespace UnleashedApi.Models
{
    public class Currency : IKey
    {
        public Guid Guid { get; set; }
        public string CurrencyCode { get; set; }
        public string Description { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
}
