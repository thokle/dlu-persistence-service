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
    
    public partial class DLU_Opportunity_Entry_VSIFT_4
    {
        public byte Active { get; set; }
        public string Sales_Cycle_Code { get; set; }
        public int Sales_Cycle_Stage { get; set; }
        public System.DateTime Estimated_Close_Date { get; set; }
        public Nullable<long> C_Cnt { get; set; }
        public Nullable<decimal> SUM_Estimated_Value__LCY_ { get; set; }
        public Nullable<decimal> SUM_Calcd__Current_Value__LCY_ { get; set; }
        public Nullable<decimal> SUM_Days_Open { get; set; }
    }
}
