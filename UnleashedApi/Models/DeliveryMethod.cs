using System;

namespace UnleashedApi.Models
{
    public class DeliveryMethod : IKey
    {
        public Guid Guid { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string Name { get; set; }
        public bool Obsolete { get; set; }
    }
}
