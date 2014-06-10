using System;
using System.Collections.Generic;

namespace UnleashedApi.Models
{
    public class PurchaseOrder : IKey
    {
        public Guid Guid { get; set; }
        public decimal? BCSubTotal { get; set; }
        public decimal? BCTaxTotal { get; set; }
        public decimal? BCTotal { get; set; }
        public string Comments { get; set; }
        public DateTime? CompletedDate { get; set; }
        public Currency Currency { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryCountry { get; set; }
        public string DeliveryName { get; set; }
        public string DeliveryPostCode { get; set; }
        public string DeliveryRegion { get; set; }
        public string DeliveryStreetAddress { get; set; }
        public string DeliverySuburb { get; set; }
        public decimal? ExchangeRate { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public string OrderStatus { get; set; }
        public bool? Printed { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public decimal SubTotal { get; set; }
        public LinkedSupplier Supplier { get; set; }
        public DateTime? SupplierInvoiceDate { get; set; }
        public string SupplierRef { get; set; }
        public Tax Tax { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? TaxTotal { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalVolume { get; set; }
        public decimal? TotalWeight { get; set; }
        public Warehouse Warehouse { get; set; }
        public string XeroTaxCode { get; set; }
        public List<PurchaseOrderLine> PurchaseOrderLines { get; set; } 
    }
}
