using System;

namespace UnleashedApi.Models
{
    public class CustomerType : IKey
    {
        public Guid Guid { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string TypeName { get; set; }
    }
}
