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
    
    public partial class Å99___dlu_General_Reg__Journal_Line
    {
        public byte[] timestamp { get; set; }
        public string Journal_Name { get; set; }
        public int Line_No_ { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_No_ { get; set; }
        public string Pay_Type_No_ { get; set; }
        public string Description { get; set; }
        public decimal Units { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public string Shortcut_Dimension_1_Code { get; set; }
        public string Shortcut_Dimension_2_Code { get; set; }
        public string Job_No_ { get; set; }
        public string Step_Code { get; set; }
        public string Phase_Code { get; set; }
        public string Task_Code { get; set; }
        public string Bank_Branch_No_ { get; set; }
        public string Bank_Account_No_ { get; set; }
        public string Nets_No_ { get; set; }
        public string User_ID { get; set; }
        public System.DateTime Reg__Journal_Date { get; set; }
        public byte Delete_after_Payroll_Posting { get; set; }
        public byte Autoline { get; set; }
        public int Holiday_Accumulation_Year { get; set; }
        public byte Actual_hours { get; set; }
        public System.DateTime Salary_Registration_Date { get; set; }
        public string Lessor_Portal_Reg__ID { get; set; }
        public int Lessor_Portal_Reg__Type { get; set; }
        public byte Lessor_Portal_Cancelled { get; set; }
        public int Account_Type { get; set; }
        public string Account_No_ { get; set; }
        public int G_L_Posting_Factor { get; set; }
        public string NemRefusion_ID { get; set; }
        public string NemRefusion_Payment_ID { get; set; }
    }
}
