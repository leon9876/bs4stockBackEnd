using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bs4stockBackEnd.Models;
namespace bs4stockBackEnd.viewModels
{
    public class VMRpt
    {
        public List<Mber> Mber { get; set; } //把table name 放在list裡
        public List<Massage> Massage { get; set; }
        public List<Report> Report { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }

        public int PageCount(int Count)
        {
            return Convert.ToInt32(Math.Ceiling(Count / (double)PageSize));
        }

        public IEnumerable<Report> PaginatedReport()
        {
            int start = (CurrentPage - 1) * PageSize;
            return Report.OrderBy(m => m.RptId).Skip(start).Take(PageSize);
        }
    }
}