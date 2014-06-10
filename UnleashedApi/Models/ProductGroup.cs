using System;

namespace UnleashedApi.Models
{
    public class ProductGroup : IKey
    {
        public Guid Guid { get; set; }
        public string GroupName { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
}
