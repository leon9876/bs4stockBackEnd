using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace bs4stockBackEnd.Models
{
    public class Report
    {
        [Key]
        [DisplayName("舉報編號")]
        public int RptId { get; set; }
        [DisplayName("留言編號")]
        public int MsId { get; set; }
        [DisplayName("會員編號")]
        public int UsId { get; set; }
        [DisplayName("舉報原因")]
        public string RptRs { get; set; }

        public virtual Mber Mber { get; set; }

        public virtual Massage Massage { get; set; }
    }
}