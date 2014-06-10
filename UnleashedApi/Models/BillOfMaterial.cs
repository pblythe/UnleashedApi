using System;
using System.Collections.Generic;

namespace UnleashedApi.Models
{
    public class BillOfMaterial : IKey
    {
        public Guid Guid { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public Product Product { get; set; } //This Could Be A Linked Product
        public List<BillOfMaterial> BillOfMaterialsLines { get; set; } 
    }
}
