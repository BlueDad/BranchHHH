//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class GradeData
    {
        public int AD_Index { get; set; }
        public string AD_UniversityName { get; set; }
        public string AD_CollegeName { get; set; }
        public Nullable<int> AD_FirstYearGradeLevel { get; set; }
        public Nullable<int> AD_SecondYearGradeLevel { get; set; }
        public Nullable<int> AD_ThirdYearGradeLevel { get; set; }
        public Nullable<int> AD_UniversityIndex { get; set; }
    
        public virtual GradeData GradeData1 { get; set; }
        public virtual GradeData GradeData2 { get; set; }
        public virtual CollegeDetail CollegeDetail { get; set; }
    }
}
