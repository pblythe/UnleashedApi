using System;

namespace UnleashedApi.Models
{
    public class LinkedProduct : IKey
    {
        public LinkedProduct(Guid guid)
        {
            Guid = guid;
        }

        public LinkedProduct(string productCode)
        {
            ProductCode = productCode;
        }

        public LinkedProduct()
        {
        }

        public Guid Guid { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
    }
}
