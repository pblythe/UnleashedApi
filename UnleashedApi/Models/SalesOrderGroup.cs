using System;

namespace UnleashedApi.Models
{
    public class SalesOrderGroup : IKey
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public DateTime? LastModifiedOn { get;set; }
    }
}
