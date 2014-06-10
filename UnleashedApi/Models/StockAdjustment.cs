using System;
using System.Collections.Generic;

namespace UnleashedApi.Models
{
    public class StockAdjustment : IKey
    {
        public Guid Guid { get; set; }
        public DateTime AdjustmentDate { get; set; }
        public string AdjustmentNumber { get; set; }
        public string AdjustmentReason { get; set; }
        public string ConfirmedBy { get; set; }
        public DateTime? ConfirmedOn { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string Status { get; set; }
        public List<StockAdjustmentLine> StockAdjustmentLines { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
