using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using bs4stockBackEnd.Models;
namespace bs4stockBackEnd.DAL
{
    public class bs4stockBackEndContext : DbContext
    {
        public bs4stockBackEndContext(): base("name=bs4stockBackEnd") //連接字web.config
        {

        }
        public DbSet<Arti> Arti { get; set; }
        public DbSet<Mager> Mager { get; set; }
        public DbSet<Mber> Mber { get; set; }
        public DbSet<Massage> Massage { get; set; }
        public System.Data.Entity.DbSet<bs4stockBackEnd.Models.Report> Report { get; set; }
    }
}