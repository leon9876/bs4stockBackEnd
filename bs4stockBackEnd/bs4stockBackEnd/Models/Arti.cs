using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bs4stockBackEnd.Models
{
    public class Arti
    {
        [Key]
        [DisplayName("連結編號")]
        public int ArId { get; set; }
        [DisplayName("連結名稱")]
        public String ArName { get; set; }
        [DisplayName("連結內容")]
        public String ArCt { get; set; }
    }
}