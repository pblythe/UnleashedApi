using System.Collections.Generic;

namespace UnleashedApi.Models
{
    public class CustomerAddress
    {
        public string CustomerCode { get; set; }
        public List<Address> Addresses { get; set; } 
    }
}
