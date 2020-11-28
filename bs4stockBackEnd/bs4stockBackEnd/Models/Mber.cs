using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bs4stockBackEnd.Models
{
    public class Mber
    {
        [Key]
        [DisplayName("會員編號")]
        public int UsId { get; set; }
        [DisplayName("投資者類型")]
        public int ITId { get; set; }
        [DisplayName("會員信箱")]
        public string UsEmail { get; set; }
        [DisplayName("會員密碼")]
        public string UsPwd { get; set; }
        [DisplayName("會員姓名")]
        public string UsName { get; set; }
        [DisplayName("會員性別")]
        public Nullable<bool> UsSex { get; set; }
        [DisplayName("會員電話")]
        public string UsPh { get; set; }
        [DisplayName("會員註冊日期")]
        public Nullable<System.DateTime> UsJnd { get; set; }
        [DisplayName("會員驗證狀態")]
        public Nullable<bool> UsVdS { get; set; }
        
        [DisplayName("封鎖狀態")]
        public Nullable<bool> UsLkS { get; set; }
        [DisplayName("封鎖時間")]
        public Nullable<System.DateTime> UsLkT { get; set; }
        [DisplayName("解鎖時間")]
        public Nullable<System.DateTime> UsULkT { get; set; }
        [DisplayName("違規次數")]
        public Nullable<int> UsLkC { get; set; }
    }
}