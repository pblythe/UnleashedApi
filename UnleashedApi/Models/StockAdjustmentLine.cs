using System;

namespace UnleashedApi.Models
{
    public class StockAdjustmentLine : IKey
    {
        public Guid Guid { get; set; }
        public string Comments { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int LineNumber { get; set; }
        public decimal? NewActualValue { get; set; }
        public decimal? NewQuantity { get; set; }
        public LinkedProduct Product { get; set; }
    }
}
