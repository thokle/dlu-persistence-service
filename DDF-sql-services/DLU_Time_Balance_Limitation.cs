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
    
    public partial class DLU_Time_Balance_Limitation
    {
        public byte[] timestamp { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public System.DateTime Last_Date_Modified { get; set; }
        public int Scheduled_Time_Delimitation { get; set; }
        public string Time_Balance_Code { get; set; }
        public byte Create_on_Statutory_Holidays { get; set; }
        public string Calculate_From { get; set; }
        public string Calculate_To { get; set; }
        public string Calculation_Frequency { get; set; }
        public string Statutory_Hol__Calendar_Code { get; set; }
        public byte Fill_up { get; set; }
        public decimal Hours_From { get; set; }
        public decimal Hours_To { get; set; }
        public string Time_Type_Code { get; set; }
        public string Day_Filter { get; set; }
        public string Remove_from_Lookup_Form { get; set; }
    }
}
