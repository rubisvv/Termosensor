using System;

namespace Termosensor
{
    public class PageViewModel
    {
        public int PageNumber { get; private set; }
        public int TotalPages { get; private set; }

        public PageViewModel (int count, int pageNamber, int pageSize)
        {
            PageNumber = pageNamber;
            TotalPages = (int)Math.Ceiling(count/(double)pageSize);
        }

        public Boolean HasPreviousPage
        {
            get { return (PageNumber > 1); }
        }

        public Boolean HasNextPage
        {   
            get { return (PageNumber < TotalPages); }
        }
    }
}
