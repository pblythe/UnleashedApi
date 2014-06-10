using System;

namespace UnleashedApi.Models
{
    public class WarehouseStockTransferLine
    {
        public decimal AvailableQuantity { get; set; }
        public decimal? AverageLandedPriceAtTimeOfTransfer { get; set; }
        public string BatchNumber { get; set; }
        public string Comments { get; set; }
        public decimal? DestinateWarehouseStockOnHandBeforeTransfer { get; set; }
        public int DestinationWarehouseId { get; set; }
        public int DestinationWarehouseLocationId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int LineNumber { get; set; }
        public DateTime ReceiptFIFODate { get; set; }
        public int SourceWarehouseId { get; set; }
        public decimal? SourceWarehouseStockOnHandBeforeTransfer { get; set; }
        public int TransferOrderId { get; set; }
        public decimal TransferQuantity { get; set; }
        public int WarehouseLocationId { get; set; }
        public int WarehouseProductId { get; set; }
    }
}
