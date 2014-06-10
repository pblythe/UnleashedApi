using System;

namespace UnleashedApi.Models
{
    public class SalesOrderLine : IKey
    {
        public SalesOrderLine()
        {
            Product = new LinkedProduct();
        }

        public Guid Guid { get; set; }
        public decimal? UnitCost { get; set; }		
        public decimal BCLineTax { get; set; }
        public decimal BCLineTotal { get; set; }
        public decimal BCUnitPrice { get; set; }
        public string Comments { get; set; }
        public decimal DiscountRate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int LineNumber { get; set; }
        public decimal LineTax { get;set; }
        public string LineTaxCode { get; set; }
        public decimal LineTotal { get; set; }
        public decimal OrderQuantity { get; set; }
        public LinkedProduct Product { get; set; }	
        public decimal? TaxRate { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Weight { get; set; }
        public string XeroSalesAccount { get; set; }
        public string XeroTaxCode { get; set; }
    }
}
