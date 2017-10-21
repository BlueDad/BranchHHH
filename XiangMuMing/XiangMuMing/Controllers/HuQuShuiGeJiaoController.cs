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


        College_ABCEntities FuckingDB = new College_ABCEntities(); 

        // GET: HuQuShuiGeJiao
        public ActionResult Index()
        {
         
            return View();
        }

        public JsonResult Create()
        {

            Useless useless = new Useless();


            var aaaa = new JsonResult();
            //List<Useless> Useless = new List<Useless>();




            aaaa.Data = useless;

            aaaa.JsonRequestBehavior = JsonRequestBehavior.AllowGet;

            FuckingDB.Uselesses.Add(useless);
            FuckingDB.SaveChanges();

            return aaaa;
        }

        public JsonResult Delete()
        {


            Useless useless = new Useless();

            var aaaa = new JsonResult();
            //List<Useless> Useless = new List<Useless>();

            aaaa.Data = useless;

            aaaa.JsonRequestBehavior = JsonRequestBehavior.AllowGet;

            FuckingDB.Uselesses.Remove(useless);
            FuckingDB.SaveChanges();



            return aaaa;




        }

        public JsonResult Edit()
        {
            Useless useless = new Useless();


            var aaaa = new JsonResult();
            //List<Useless> Useless = new List<Useless>();




            aaaa.Data = useless;

            aaaa.JsonRequestBehavior = JsonRequestBehavior.AllowGet;

            FuckingDB.Uselesses.Add(useless);
            FuckingDB.SaveChanges();

            return aaaa;

        }



    }
}