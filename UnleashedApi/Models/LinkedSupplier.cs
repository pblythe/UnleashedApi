using System;

namespace UnleashedApi.Models
{
    public class LinkedSupplier : IKey
    {
        public LinkedSupplier(Guid guid)
        {
            Guid = guid;
        }

        public LinkedSupplier(string supplierCode)
        {
            SupplierCode = supplierCode;
        }

        public LinkedSupplier()
        {
        }

        public Guid Guid { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
    }
}
