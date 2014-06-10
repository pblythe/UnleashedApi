using System;

namespace UnleashedApi.Models
{
    public class StockOnHand : IKey
    {
        public Guid Guid { get; set; }
        public decimal AllocatedQty { get; set; }
        public decimal AvailableQty { get; set; }
        public decimal AvgCost { get; set; }
        public int DaysSinceLastSale { get; set; }
        public DateTime? LastModifiedOn { get; set; }
		public decimal OnPurchase { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string ProductGroupName { get; set; }
        public Guid ProductGuid { get; set; }
        public string ProductSourceId { get; set; }
        public decimal QtyOnHand { get; set; }
	    public decimal TotalCost { get; set; }
        public string Warehouse { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseId { get; set; }
    }
}
