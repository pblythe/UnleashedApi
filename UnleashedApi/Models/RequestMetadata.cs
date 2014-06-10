using System.Collections.Generic;

namespace UnleashedApi.Models
{
    public class RequestMetadata<T>
    {
        public List<T> Items { get; set; }
        public PaginationMetadata Pagination { get; set; }
    }
}
