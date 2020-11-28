using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using bs4stockBackEnd.Models;

namespace bs4stockBackEnd.DAL
{
    public class bs4stockBackEndInitializer : DropCreateDatabaseAlways<bs4stockBackEndContext>
    {

        protected override void Seed(bs4stockBackEndContext context)
        {
            base.Seed(context);

            String UsJnd = "1/1/2020";
            String UsLkT = "03 July 2020 7:32:47 AM";
            String UsULkT = "17 July 2020 7:32:47 AM";
            List<Mber> Mber = new List<Mber>
            {
                new Mber
                {
                 ITId=1,
                 UsEmail="alex@gmail.com",
                 UsPwd ="11",
                 UsName="alex",
                 UsSex=true,
                 UsPh="0911111111",
                 UsJnd=Convert.ToDateTime(UsJnd),
                 UsVdS=true,
                 UsLkS=false,
                 UsLkT=null,
                 UsULkT=null,
                 UsLkC=0
                },
                new Mber
                {ITId=1,
                 UsEmail="baolan@gmail.com",
                 UsPwd ="22",
                 UsName="baolan",
                 UsSex=false,
                 UsPh="0922222222",
                 UsJnd=Convert.ToDateTime(UsJnd),
                 UsVdS=true,
                 UsLkS=false,
                 UsLkT=null,
                 UsULkT=null,
                 UsLkC=1
                },
                new Mber
                {ITId=1,
                 UsEmail="kevin@gmail.com",
                 UsPwd ="33",
                 UsName="kevin",
                 UsSex=true,
                 UsPh="0933333333",
                 UsJnd=Convert.ToDateTime(UsJnd),
                 UsVdS=true,
                 UsLkS=false,
                 UsLkT=null,
                 UsULkT=null,
                 UsLkC=1
                },
               new Mber
                {ITId=1,
                 UsEmail="weather@gmail.com",
                 UsPwd ="44",
                 UsName="weather",
                 UsSex=true,
                 UsPh="0944444444",
                 UsJnd=Convert.ToDateTime(UsJnd),
                 UsVdS=true,
                 UsLkS=false,
                 UsLkT=null,
                 UsULkT=null,
                 UsLkC=2
               },
               new Mber
                {ITId=1,
                 UsEmail="d@gmail.com",
                 UsPwd ="55",
                 UsName="computer",
                 UsSex=true,
                 UsPh="0955555555",
                 UsJnd=Convert.ToDateTime(UsJnd),
                 UsVdS=true,
                 UsLkS=false,
                 UsLkT=null,
                 UsULkT=null,
                 UsLkC=2
               },
               new Mber
                {ITId=1,
                 UsEmail="d@gmail.com",
                 UsPwd ="66",
                 UsName="Amy",
                 UsSex=false,
                 UsPh="0966666666",
                 UsJnd=Convert.ToDateTime(UsJnd),
                 UsVdS=true,
                 UsLkS=false,
                 UsLkT=null,
                 UsULkT=null,
                 UsLkC=2
               },
               new Mber
                {ITId=1,
                 UsEmail="zven@gmail.com",
                 UsPwd ="77",
                 UsName="zven",
                 UsSex=true,
                 UsPh="0977777777",
                 UsJnd=Convert.ToDateTime(UsJnd),
                 UsVdS=true,
                 UsLkS=false,
                 UsLkT=null,
                 UsULkT=null,
                 UsLkC=2
               },
               new Mber
                {ITId=1,
                 UsEmail="skr@gmail.com",
                 UsPwd ="88",
                 UsName="skr",
                 UsSex=true,
                 UsPh="0988888888",
                 UsJnd=Convert.ToDateTime(UsJnd),
                 UsVdS=true,
                 UsLkS=false,
                 UsLkT=null,
                 UsULkT=null,
                 UsLkC=2
               },
               new Mber
                {ITId=1,
                 UsEmail="food@gmail.com",
                 UsPwd ="99",
                 UsName="food",
                 UsSex=true,
                 UsPh="0999999999",
                 UsJnd=Convert.ToDateTime(UsJnd),
                 UsVdS=true,
                 UsLkS=false,
                 UsLkT=null,
                 UsULkT=null,
                 UsLkC=2
               },
              new Mber
                {ITId=1,
                 UsEmail="d@gmail.com",
                 UsPwd ="55",
                 UsName="computer",
                 UsSex=true,
                 UsPh="0955555555",
                 UsJnd=Convert.ToDateTime(UsJnd),
                 UsVdS=true,
                 UsLkS=false,
                 UsLkT=null,
                 UsULkT=null,
                 UsLkC=2
               },
               new Mber
                {ITId=1,
                 UsEmail="music@gmail.com",
                 UsPwd ="00",
                 UsName="music",
                 UsSex=true,
                 UsPh="0955555555",
                 UsJnd=Convert.ToDateTime(UsJnd),
                 UsVdS=true,
                 UsLkS=true,
                 UsLkT=Convert.ToDateTime(UsLkT),
                 UsULkT=Convert.ToDateTime(UsULkT),
                 UsLkC=2
               },
                new Mber
                {ITId=1,
                 UsEmail="@gmail.com",
                 UsPwd ="12",
                 UsName="electic",
                 UsSex=true,
                 UsPh="0912121212",
                 UsJnd=Convert.ToDateTime(UsJnd),
                 UsVdS=true,
                 UsLkS=true,
                 UsLkT=Convert.ToDateTime(UsLkT),
                 UsULkT=Convert.ToDateTime(UsULkT),
                 UsLkC=2
               },
             };

            Mber.ForEach(s => context.Mber.Add(s));
            context.SaveChanges();

            List<Arti> Arti = new List<Arti>
            {
                new Arti
                {
                 ArName="從股票中獲利的祕訣_google",
                 ArCt="https://www.google.com",
                },
                new Arti
                {
                  ArName="從股票中獲利的祕訣2_yahoo",
                  ArCt="https://www.yahoo.com.tw"
                },
               new Arti
                {
                  ArName="從股票中獲利的祕訣_firefox",
                   ArCt="https://www.mozilla.org/zh-TW/firefox/new/"
               },
                new Arti
                {
                  ArName="從股票中獲利的祕訣_firefox",
                   ArCt="https://www.mozilla.org/zh-TW/firefox/new/"
               },
                 new Arti
                {
                  ArName="從股票中獲利的祕訣_firefox",
                   ArCt="https://www.mozilla.org/zh-TW/firefox/new/"
               },
                  new Arti
                {
                  ArName="從股票中獲利的祕訣_firefox",
                   ArCt="https://www.mozilla.org/zh-TW/firefox/new/"
               },
                   new Arti
                {
                  ArName="從股票中獲利的祕訣_firefox",
                   ArCt="https://www.mozilla.org/zh-TW/firefox/new/"
               },
                    new Arti
                {
                  ArName="從股票中獲利的祕訣_firefox",
                   ArCt="https://www.mozilla.org/zh-TW/firefox/new/"
               },
                     new Arti
                {
                  ArName="從股票中獲利的祕訣_firefox",
                   ArCt="https://www.mozilla.org/zh-TW/firefox/new/"
               },
                      new Arti
                {
                  ArName="從股票中獲利的祕訣_firefox",
                   ArCt="https://www.mozilla.org/zh-TW/firefox/new/"
               },
                           new Arti
                {
                  ArName="從股票中獲利的祕訣_firefox",
                   ArCt="https://www.mozilla.org/zh-TW/firefox/new/"
               },
             };

            Arti.ForEach(s => context.Arti.Add(s));
            context.SaveChanges();

            List<Massage> Massage = new List<Massage>
            {
                new Massage
                {
                      Ms_R=0,
                      UsId=1,
                      MsDate=null,
                      MsCont="XX，這群小XX，都已經被套牢了，還不知道??",
                      MsGd=true,
                      MsGd_Ct=3,
                      MsBad=true,
                      MsBad_Ct=1,
                      MsRptS=true,
                      MsHdS=false,
                },
                new Massage
                {
                      Ms_R=0,
                      UsId=2,
                      MsDate=null,
                      MsCont="XX，這群小XX，都已經被套牢了，還不知道??",
                      MsGd=true,
                      MsGd_Ct=3,
                      MsBad=true,
                      MsBad_Ct=1,
                      MsRptS=true,
                      MsHdS=false,
                 },
                new Massage
                {
                      Ms_R=1,
                      UsId=3,
                      MsDate=null,
                      MsCont="XX，這群小XX，都已經被套牢了，還不知道??",
                      MsGd=true,
                      MsGd_Ct=3,
                      MsBad=true,
                      MsBad_Ct=1,
                      MsRptS=true,
                      MsHdS=false,
                 },
                new Massage
                {
                      Ms_R=1,
                      UsId=4,
                      MsDate=null,
                      MsCont="XX，這群小XX，都已經被套牢了，還不知道??",
                      MsGd=true,
                      MsGd_Ct=3,
                      MsBad=true,
                      MsBad_Ct=1,
                      MsRptS=true,
                      MsHdS=false,
                 },
                new Massage
                {
                      Ms_R=1,
                      UsId=5,
                      MsDate=null,
                      MsCont="XX，這群小XX，都已經被套牢了，還不知道??",
                      MsGd=true,
                      MsGd_Ct=3,
                      MsBad=true,
                      MsBad_Ct=1,
                      MsRptS=false,
                      MsHdS=false,
                 },
            };
            Massage.ForEach(s => context.Massage.Add(s));
            context.SaveChanges();

            List<Mager> Mager = new List<Mager>
            {
                new Mager
                {
                      MaAct="M1",
                      MaPwd="123456",
                      Authority=15,
                      AuthorityS="新增 刪除 修改 管理權限",

                 },
                new Mager
                {
                      MaAct="M2",
                      MaPwd="222",
                      Authority=1,
                      AuthorityS="新增",
                 },
                 new Mager
                {MaAct="M3",
                     MaPwd="333",
                      Authority=2,
                      AuthorityS="刪除",
                 },
                  new Mager
                {MaAct="M4",
                     MaPwd="444",
                      Authority=5,
                      AuthorityS="新增 刪除",
                 },
                  new Mager
                {MaAct="M5",
                     MaPwd="555",
                      Authority=13,
                      AuthorityS="新增 刪除 修改",
                 },
                  new Mager
                {MaAct="M6",
                     MaPwd="666",
                      Authority=13,
                      AuthorityS="新增 刪除 修改",
                 },
                   new Mager
                {MaAct="M7",
                     MaPwd="777",
                      Authority=13,
                      AuthorityS="新增 刪除 修改",
                 },
                   new Mager
                {MaAct="M8",
                     MaPwd="888",
                      Authority=13,
                      AuthorityS="新增 刪除 修改",
                 },
                  new Mager
                {MaAct="M9",
                     MaPwd="999",
                      Authority=13,
                      AuthorityS="新增 刪除 修改",
                 },
                  new Mager
                {MaAct="M10",
                     MaPwd="000",
                      Authority=13,
                      AuthorityS="新增 刪除 修改",
                 },
                  new Mager
                {MaAct="M11",
                     MaPwd="121",
                      Authority=13,
                      AuthorityS="新增 刪除 修改",
                 },
            };
            Mager.ForEach(s => context.Mager.Add(s));
            context.SaveChanges();
            List<Report> Report = new List<Report>
            {
                new Report
                {
                      MsId=1,
                      UsId=1,
                      RptRs="不雅言論超過3個字",

                 },
                new Report
                {
                      MsId=2,
                      UsId=2,
                      RptRs="不雅言論超過3個字",
                 },
                new Report
                {
                      MsId=3,
                      UsId=3,
                      RptRs="不雅言論超過3個字",
                 },
                new Report
                {
                      MsId=4,
                      UsId=4,
                      RptRs="不雅言論超過3個字",
                 },
            };
            Report.ForEach(s => context.Report.Add(s));
            context.SaveChanges();
        }
    }
}
