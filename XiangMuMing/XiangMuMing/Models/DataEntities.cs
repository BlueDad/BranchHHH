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
    public class HHHEntities : DbContext
    {

        public DbSet<WhatsTheFuck> WhatsTheFuck { get; set; }

    }

}