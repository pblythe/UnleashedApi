using System;
using System.Collections.Generic;

namespace UnleashedApi.Models
{
    public class SalesShipment : IKey 
    {
        public Guid Guid { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? DispatchDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public string OrderNumber { get; set; }
        public List<SalesShipmentLine> SalesShipmentLines { get; set; }
        public string ShipmentNumber { get; set; }
        public string ShipmentStatus { get; set; }
    }
}
