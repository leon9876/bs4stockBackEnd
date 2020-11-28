using bs4stockBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bs4stockBackEnd.viewModels
{
    public class VMpage
    {
        public List<Arti> Arti { get; set; }

        public List<Mber> Mber { get; set; }
        
        public List<Mager> Mager { get; set; }

        public int PageSize { get; set; }
        public int CurrentPage { get; set; }

        public int PageCount(int Count)
        {
            return Convert.ToInt32(Math.Ceiling(Count/ (double)PageSize));
        }
        public IEnumerable<Arti> PaginatedArti()
        {
            int start = (CurrentPage - 1) * PageSize;
            return Arti.OrderBy(m => m.ArId).Skip(start).Take(PageSize);
        }
        public IEnumerable<Mber> PaginatedMber()
        {
            int start = (CurrentPage - 1) * PageSize;
            return Mber.OrderBy(m => m.UsId).Skip(start).Take(PageSize);
        }
        public IEnumerable<Mager> PaginatedMager()
        {
            int start = (CurrentPage - 1) * PageSize;
            return Mager.OrderBy(m => m.MaId).Skip(start).Take(PageSize);
        }
    }
}