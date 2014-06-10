using System;
using System.Collections.Generic;

namespace UnleashedApi.Models
{
    public class Customer : IKey
    {
        public Customer()
        {
            Addresses = new List<Address>();
            SalesPerson = new SalesPerson();
            Currency = new Currency();
        }

        public Guid Guid { get; set; }
        public string BankAccount { get;set; }	
	    public string BankBranch { get;set; }
	    public string BankName { get;set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerType { get; set; }
        public string CreatedBy { get; set; }
        public string DDINumber { get; set; }
        public decimal? DiscountRate { get; set; }
        public string Email { get; set; }
        public string EmailCC { get; set; }
        public string FaxNumber { get; set; }
        public string GSTVATNumber { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string MobileNumber { get; set; }
        public string Notes { get;set; }
        public bool Obsolete { get;set; }
        public string PaymentTerm { get; set; }
        public string PhoneNumber { get; set; }
        public bool? PrintInvoice { get; set; }
        public bool? PrintPackingSlipInsteadOfInvoice { get; set; }
        public string SellPriceTier { get; set; }
        public string SellPriceTierReference { get; set; }
        public string SourceId { get; set; }
        public bool StopCredit { get; set; }
        public bool? Taxable { get; set; }
        public string TollFreeNumber { get; set; }
        public string Website { get; set; }
        public string XeroContactId { get;set; }
        public string XeroCostOfGoodsAccount { get; set; }
        public string XeroSalesAccount { get; set; }
        public List<Address> Addresses { get; set; }
        public SalesPerson SalesPerson { get; set; }
        public Currency Currency { get; set; }	
    }
}
