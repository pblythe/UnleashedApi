using System;

namespace UnleashedApi.Models
{
    public class LinkedCustomer : IKey
    {
        public LinkedCustomer()
        {
        }

        public LinkedCustomer(Guid guid)
        {
            Guid = guid;
        }

        public LinkedCustomer(string customerCode)
        {
            CustomerCode = customerCode;
        }

        public Guid Guid { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
}
