//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DDF_sql_services
{
    using System;
    using System.Collections.Generic;
    
    public partial class DLU_Employee_Absence_VSIFT_6
    {
        public int Absence_Type { get; set; }
        public string Employee_No_ { get; set; }
        public string Cause_of_Absence_Code { get; set; }
        public System.DateTime From_Date { get; set; }
        public Nullable<long> C_Cnt { get; set; }
        public Nullable<decimal> SUM_Days { get; set; }
    }
}