using System;

namespace UnleashedApi.Models
{
    public class PurchaseOrderLine : IKey
    {
        public Guid Guid { get; set; }
        public decimal? BCSubTotal { get; set; }
        public decimal? BCUnitPrice { get; set; }
        public string Comments { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int LineNumber { get; set; }
        public decimal? LineTax { get; set; }
        public decimal LineTotal { get; set; }
        public decimal OrderQuantity { get; set; }
        public LinkedProduct Product { get; set; }
        public decimal? ReceiptQuantity { get; set; }
        public Tax Tax { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Weight { get; set; }
    }
}
