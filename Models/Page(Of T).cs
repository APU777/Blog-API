using System;
namespace Models
{
    public class Page_Of_T_
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int Records { get; set; }
        public int TotalPages { get; set; }
    }
}
