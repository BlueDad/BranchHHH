﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace XiangMuMing
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class College_ABCEntities : DbContext
    {
        public College_ABCEntities()
            : base("name=College_ABCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GradeData> GradeDatas { get; set; }
        public virtual DbSet<RankingData> RankingDatas { get; set; }
        public virtual DbSet<CollegeDetail> CollegeDetails { get; set; }
        public virtual DbSet<Useless> Uselesses { get; set; }
    }
}
