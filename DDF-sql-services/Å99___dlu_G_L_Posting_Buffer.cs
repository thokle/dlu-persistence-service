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
    
    public partial class Å99___dlu_G_L_Posting_Buffer
    {
        public byte[] timestamp { get; set; }
        public int Entry_No_ { get; set; }
        public int Account_Type { get; set; }
        public string Account_No_ { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public string Employee_No_ { get; set; }
        public decimal Amount { get; set; }
        public string Global_Dimension_1_Code { get; set; }
        public string Global_Dimension_2_Code { get; set; }
        public string Job_No_ { get; set; }
        public string Step_Code { get; set; }
        public string Phase_Code { get; set; }
        public string Task_Code { get; set; }
        public System.DateTime Reg__Journal_Date { get; set; }
        public string Payroll_Posting_No_ { get; set; }
        public byte Holds_Dimensions { get; set; }
        public System.DateTime Salary_Registration_Date { get; set; }
        public string Lessor_Portal_Reg__ID { get; set; }
        public int Lessor_Portal_Reg__Type { get; set; }
        public byte Lessor_Portal_Cancelled { get; set; }
    }
}
