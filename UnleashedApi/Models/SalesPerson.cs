using System;

namespace UnleashedApi.Models
{
    public class SalesPerson : IKey
    {
        public Guid Guid { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public bool Obsolete { get; set; }
    }
}
