using System;

namespace UnleashedApi.Models
{
    public class Warehouse : IKey
    {
        public Guid Guid { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string ContactName { get; set; }
        public string Country { get; set; }
        public string DDINumber { get; set; }
        public string FaxNumber { get; set; }
        public bool IsDefault { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string MobileNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string PostCode { get; set; }
        public string Region { get; set; }
        public string StreetNo { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
    }
}
