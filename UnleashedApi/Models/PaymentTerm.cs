using System;

namespace UnleashedApi.Models
{
    public class PaymentTerm : IKey
    {
        public Guid Guid { get; set; }
        public int? Days { get; set; }
        public bool Obsolete { get; set; }
        public string PaymentTermDescription { get; set; }
        public string Type { get; set; }
    }
}
