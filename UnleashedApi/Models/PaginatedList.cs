using System.Collections.Generic;

namespace UnleashedApi.Models
{
    public class PaginatedList<T> : List<T>, IPaginatedList<T>
    {
        private readonly int _numberOfItems;
        private readonly int _numberOfPages;
        private readonly int _pageNumber;
        private readonly int _pageSize;

        public PaginatedList(IEnumerable<T> items = null, int numberOfItems = 0, int numberOfPages = 0, int pageNumber = 0, int pageSize = 0)
        {
            _numberOfItems = numberOfItems;
            _numberOfPages = numberOfPages;
            _pageNumber = pageNumber;
            _pageSize = pageSize;
            if (items != null)
                AddRange(items);
        }

        public int NumberOfItems
        {
            get { return _numberOfItems; }
        }

        public int NumberOfPages
        {
            get { return _numberOfPages; }
        }

        public int PageNumber
        {
            get { return _pageNumber; }
        }

        public int PageSize
        {
            get { return _pageSize; }
        }
    }
}
