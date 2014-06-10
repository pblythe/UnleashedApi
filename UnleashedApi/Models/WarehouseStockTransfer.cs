using System;
using System.Collections.Generic;

namespace UnleashedApi.Models
{
    public class WarehouseStockTransfer : IKey
    {
        public Guid Guid { get; set; }
        public string Comments { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Warehouse DestinationWarehouse { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public DateTime OrderDate { get; set; }
        public Warehouse SourceWarehouse { get; set; }
        public string TransferOrderNumber { get; set; }
        public string TransferStatus { get; set; }
        public List<WarehouseStockTransferLine> TransferDetails { get; set; } 
    }
}
