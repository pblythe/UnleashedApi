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

            InvoiceLines = new List<SalesInvoiceLine>();
        }

        public Guid Guid { get; set; }
        public decimal? BCSubTotal { get; set; }
        public decimal? BCTaxTotal { get; set; }
        public decimal? BCTotal { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Currency Currency { get; set; }
        public LinkedCustomer Customer { get; set; }
		public string CustomerRef { get; set; }
        public CustomerAddress DeliveryAddress { get; set; }
        public string DeliveryInstruction { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string OrderNumber { get; set; }
        public string QuoteNumber { get; set; }
        public string InvoiceStatus { get; set; }
        public DateTime? DueDate { get; set; }
	    public string PaymentTerm { get; set; }
        public List<SalesInvoiceLine> InvoiceLines { get; set; }
    }
}
