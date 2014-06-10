using System;

namespace UnleashedApi.Models
{
    public class BillOfMaterialLine
    {
        public Guid Guid { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int LineNumber { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal WastageQuantity { get; set; }
    }
}
