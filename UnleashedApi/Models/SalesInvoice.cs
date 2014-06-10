using System;
using System.Collections.Generic;

namespace UnleashedApi.Models
{
    public class SalesInvoice : IKey
    {
        public SalesInvoice()
        {
            Currency = new Currency();
            Customer = new LinkedCustomer();
            SalesOrderLines = new List<SalesOrderLine>();
            SalesPerson = new SalesPerson();
            Tax = new Tax();
            Warehouse = new Warehouse();
        }

        public Guid Guid { get; set; }
        public decimal? BCSubTotal { get; set; }
        public decimal? BCTaxTotal { get; set; }
        public decimal? BCTotal { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public Currency Currency { get; set; }
        public LinkedCustomer Customer { get; set; }
		public string CustomerRef { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryCountry { get; set; }
        public string DeliveryMethod { get; set; }
        public string DeliveryName { get; set; }
        public string DeliveryPostCode { get; set; }
        public string DeliveryRegion { get; set; }
        public string DeliveryStreetAddress { get; set; }
        public string DeliverySuburb { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal? ExchangeRate { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public string OrderStatus { get; set; }
        public DateTime? PaymentDueDate { get; set; }
        public DateTime? QuoteExpiryDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string SalesOrderGroup { get; set; }
        public List<SalesOrderLine> SalesOrderLines { get; set; }
        public SalesPerson SalesPerson { get; set; }
        public bool SendAccountingJournalOnly { get; set; }
        public string SourceId { get; set; }
        public decimal SubTotal { get; set; }
        public Tax Tax { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? TaxTotal { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalVolume { get; set; }
        public decimal? TotalWeight { get; set; }
		public Warehouse Warehouse { get; set; }
	    public string XeroTaxCode { get; set; }
    }
}
