using System.Collections.Generic;

namespace UnleashedApi.Models
{
    public interface IPaginatedList<T> : IList<T>
    {
        int NumberOfItems { get; }
        int NumberOfPages { get; }
        int PageNumber { get; }
        int PageSize { get; } 
    }
}
