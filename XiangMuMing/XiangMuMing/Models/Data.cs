using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace XiangMuMing.Models
{
    public class WhatsTheFuck
    {
        public int D_Index { get; set; }

        public int D_JiaGe { get; set; }

        public int D_YouFei { get; set; }

        public int D_YouHuiQuan { get; set; }

        public int D_BaoYou { get; set; }

        public int D_XiaDanLiJian { get; set; }

        public int D_YuFuDingJin { get; set; }

        public int D_ZuiHouJiaGe { get; set; }

    }

}