using System;

namespace UnleashedApi.Models
{
    public class SalesShipmentLine : IKey
    {
        public Guid Guid { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int LineNumber { get; set; }
        public LinkedProduct Product { get; set; }
        public decimal ShipmentQty { get; set; }
        public decimal UnitCost { get; set; }
    }
}
