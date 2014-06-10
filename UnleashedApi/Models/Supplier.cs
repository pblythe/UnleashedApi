using System;

namespace UnleashedApi.Models
{
    public class Supplier : IKey
    {
        public Guid Guid { get; set; }
        public string BankAccount { get; set; }
        public string BankBranch { get; set; }
        public string BankName { get; set; }
        public string DDINumber { get; set; }
        public string Email { get; set; }
        public string FaxNumber { get; set; }
        public string GSTVATNumber { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string MobileNumber { get; set; }
        public string Notes { get; set; }
        public string PhoneNumber { get; set; }
		public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public bool Taxable { get; set; }
        public string TollFreeNumber { get; set; }
        public string Website { get; set; }
        public string XeroContactId { get; set; }
    }
}
