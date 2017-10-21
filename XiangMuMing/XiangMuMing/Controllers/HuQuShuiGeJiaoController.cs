using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XiangMuMing.Models;

namespace XiangMuMing.Controllers
{
    public class HuQuShuiGeJiaoController : Controller
    {

        static int a = 1;

        College_ABCEntities FuckingDB = new College_ABCEntities(); 

        // GET: HuQuShuiGeJiao
        public ActionResult Index()
        {

            a = a - 1;
            if(a==0 && Session["UserID"] != null)
            {
                string deleteSql = "TRUNCATE TABLE dbo.Grade";
                FuckingDB.Database.ExecuteSqlCommand(deleteSql);
            }

            return View();
        }



        public void HHHH()      //DeleteAll
        {
            string deleteSql = "TRUNCATE TABLE dbo.Grade";
            FuckingDB.Database.ExecuteSqlCommand(deleteSql);
        }







        public JsonResult Hualala()     //List
        {
            var uselessList = from s in FuckingDB.Uselesses where(s.Indx!= 0) select s;
            var aaaa = new JsonResult();
            aaaa.Data = uselessList;

            return aaaa;
        }



        //总价
        public double AAADF(double YouHuiQuanTiaojian, double YongHuiQuanJianDuoShao,double JiJian, double MaiJiJianDaJiZhe,double YouFei, double BaoYouTiaoJian)    
        {
            var uselessList = from s in FuckingDB.Uselesses where (s.Indx != 0) select s;
            Useless uii = uselessList.Last();

            double all = 0;

            foreach (var item in uselessList)
            {
                all = item.JiaGe - item.XiaDanLiJian;

                all = item.JiaGe + item.YuFuDingJin - item.YuFuDingJinDiDuoShao;     

            }

            if (all> YouHuiQuanTiaojian)
            {
                all = all - YongHuiQuanJianDuoShao;
            }

            if (uselessList.Count() > JiJian)
            {
                all = all * MaiJiJianDaJiZhe/10;
            }

            if (all < BaoYouTiaoJian)
            {
                all = all + YouFei;
            }


            return all;
        }



        public bool Create(double JiaGe, double XiaDanLiJian, double YuFuDingJin, string MingZi, double YuFuDingJinDiDuoShao)
        {
            //解析时，null为0


            Session["UserID"] = new Guid();

            Useless useless = new Useless();


            useless.JiaGe = JiaGe;
            useless.XiaDanLiJian = XiaDanLiJian;
            useless.YuFuDingJin = YuFuDingJin;
            useless.MingZi = MingZi;
            useless.YuFuDingJinDiDuoShao = YuFuDingJinDiDuoShao;


            FuckingDB.Uselesses.Add(useless);
            FuckingDB.SaveChanges();

            return true;
        }

        public bool Delete(int Indx)
        {


            var uselessList = from s in FuckingDB.Uselesses where (s.Indx == Indx) select s;
            Useless useless= uselessList.Last();

            FuckingDB.Uselesses.Remove(useless);
            FuckingDB.SaveChanges();

            return true;

        }


        public bool Edit(int Indx, double JiaGe, double XiaDanLiJian, double YuFuDingJin, string MingZi, double YuFuDingJinDiDuoShao)
        {


            var uselessList = from s in FuckingDB.Uselesses where (s.Indx == Indx) select s;
            Useless useless = uselessList.Last();

            //数据不知道是不是会正常传递+

            useless.JiaGe = JiaGe;
            useless.XiaDanLiJian = XiaDanLiJian;
            useless.YuFuDingJin = YuFuDingJin;
            useless.MingZi = MingZi;
            useless.YuFuDingJinDiDuoShao = YuFuDingJinDiDuoShao;



            FuckingDB.SaveChanges();

            return true;

        }

    }
}