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
    
    public partial class DLU_NemRefusion_Absence_Entry
    {
        public byte[] timestamp { get; set; }
        public int Entry_No_ { get; set; }
        public string Employee_No_ { get; set; }
        public string employee_source_identification { get; set; }
        public string Cause_of_Absence_Code { get; set; }
        public string NemRefusion_Code { get; set; }
        public System.DateTime From_Date { get; set; }
        public System.DateTime To_Date { get; set; }
        public int Status { get; set; }
        public string Absence_Reg__Journal_Batch { get; set; }
        public string Registration_Source_ID { get; set; }
        public System.DateTime Action_Date { get; set; }
        public System.DateTime Action_Time { get; set; }
        public byte Error { get; set; }
        public string Log_Entry_Batch_ID { get; set; }
        public byte Do_Not_Transfer { get; set; }
        public byte Split_Absence { get; set; }
        public System.DateTime Delete_Day_Start_1 { get; set; }
        public System.DateTime Delete_Day_End_1 { get; set; }
        public System.DateTime Delete_Day_Start_2 { get; set; }
        public System.DateTime Delete_Day_End_2 { get; set; }
        public int Report_Batch_ID { get; set; }
    }
}
