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
    
    public partial class DLU_Employee_Absence
    {
        public byte[] timestamp { get; set; }
        public string Absence_Reg__Journal_Batch { get; set; }
        public int Entry_No_ { get; set; }
        public string Employee_No_ { get; set; }
        public System.DateTime From_Date { get; set; }
        public System.DateTime To_Date { get; set; }
        public string Cause_of_Absence_Code { get; set; }
        public string Description { get; set; }
        public decimal Days { get; set; }
        public string Unit_of_Measure_Code { get; set; }
        public decimal Quantity__Base_ { get; set; }
        public decimal Qty__per_Unit_of_Measure { get; set; }
        public string Work_Calendar_Code { get; set; }
        public string Employee_Name { get; set; }
        public int Absence_Type { get; set; }
        public string DA_Absence_Code { get; set; }
        public decimal Hours { get; set; }
        public byte Holiday_Card { get; set; }
        public int Holiday_Accumulation_Year { get; set; }
        public string Shortcut_Dimension_1_Code { get; set; }
        public string Shortcut_Dimension_2_Code { get; set; }
        public byte Holiday_Bonus { get; set; }
        public byte Modified { get; set; }
        public byte Actual_Hours { get; set; }
        public byte Do_not_create_Pay_Reg_ { get; set; }
        public string Lessor_Portal_Reg__ID { get; set; }
        public byte Lessor_Portal_Cancelled { get; set; }
        public string Holiday_Request_Batch_ID { get; set; }
        public byte Not_DA_DS { get; set; }
        public string ACF_Payment_Purpose { get; set; }
        public int NemRefusion_Entry_No_ { get; set; }
        public System.DateTime NemRefusion_Org__From_Date { get; set; }
    }
}