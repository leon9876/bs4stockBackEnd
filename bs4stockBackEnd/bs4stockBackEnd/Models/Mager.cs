using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bs4stockBackEnd.Models
{
    public class Mager
    {
        [Key]
        [DisplayName("管理者編號")]
        public int MaId { get; set; }
        [DisplayName("管理者帳號")]
        public string MaAct { get; set; }
        [DisplayName("管理者密碼")]
        public string MaPwd { get; set; }
        [DisplayName("權限數字")]
        public int Authority { get; set; }
        [DisplayName("權限")]
        public string AuthorityS { get; set; }
    }
}