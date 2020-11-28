using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace bs4stockBackEnd.Models
{
    public class Massage
    {
        [Key]
        [DisplayName("留言編號")]
        public int MsId { get; set; }
        [DisplayName("留言順序")]
        public Nullable<int> Ms_R { get; set; }
        [DisplayName("會員編號")]
        public int UsId { get; set; }
        [DisplayName("個股編號")]
        public String StId { get; set; }
        [DisplayName("留言日期")]
        public Nullable<System.DateTime> MsDate { get; set; }
        [DisplayName("留言內容")]
        public string MsCont { get; set; }
        [DisplayName("留言讚")]
        public Nullable<bool> MsGd { get; set; }
        [DisplayName("留言讚數")]
        public Nullable<int> MsGd_Ct { get; set; }
        [DisplayName("留言爛")]
        public Nullable<bool> MsBad { get; set; }
        [DisplayName("留言爛數")]
        public Nullable<int> MsBad_Ct { get; set; }
        [DisplayName("舉報狀態")]
        public Nullable<bool> MsRptS { get; set; }
        [DisplayName("隱藏狀態")]
        public Nullable<bool> MsHdS { get; set; }


    }
}