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
    
    public partial class DLU_Pay_Entry
    {
        public byte[] timestamp { get; set; }
        public int Entry_No_ { get; set; }
        public string Employee_No_ { get; set; }
        public string Pay_Type_No_ { get; set; }
        public string Description { get; set; }
        public decimal Units { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public string Global_Dimension_1_Code { get; set; }
        public string Global_Dimension_2_Code { get; set; }
        public string Job_No_ { get; set; }
        public string Step_Code { get; set; }
        public string Phase_Code { get; set; }
        public string Task_Code { get; set; }
        public string Bank_Branch_No_ { get; set; }
        public string Bank_Account_No_ { get; set; }
        public string Nets_No_ { get; set; }
        public string User_ID { get; set; }
        public System.DateTime Reg__Journal_Date { get; set; }
        public System.DateTime Recurring_Date { get; set; }
        public byte Autoline { get; set; }
        public string Payroll_Posting_No_ { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime Net_Pay_available { get; set; }
        public byte Transferred_to_Jobs { get; set; }
        public int Reg__Journal_Type { get; set; }
        public int Reg__Journal_Line_No_ { get; set; }
        public decimal Reg__Journal_Units { get; set; }
        public decimal Reg__Journal_Rate { get; set; }
        public decimal Reg__Journal_Amount { get; set; }
        public byte Reversed { get; set; }
        public int Tax_Year { get; set; }
        public string General_Reg__Journal_Name { get; set; }
        public int Holiday_Accumulation_Year { get; set; }
        public string G_L_Journal_Batch { get; set; }
        public string G_L_Document_No_ { get; set; }
        public System.DateTime G_L_Posting_Date { get; set; }
        public byte G_L_Integration { get; set; }
        public string Rev__from_Payroll_Posting_no_ { get; set; }
        public byte Non_Taxable_Amount { get; set; }
        public int Employee_Type { get; set; }
        public string Garnishment_Sequence { get; set; }
        public int Garnishment_Withholding_Seq_ { get; set; }
        public string Nets_Text_Field { get; set; }
        public string Main_Report_ID { get; set; }
        public string Report_ID { get; set; }
        public byte Nemkonto { get; set; }
        public System.DateTime Starting_Date { get; set; }
        public System.DateTime eIndkomst_Date { get; set; }
        public int Unit_Type { get; set; }
        public System.DateTime Salary_Registration_Date { get; set; }
        public string Lessor_Portal_Reg__ID { get; set; }
        public int Lessor_Portal_Reg__Type { get; set; }
        public byte Lessor_Portal_Cancelled { get; set; }
        public string eFeriekort_ID { get; set; }
        public string IBAN { get; set; }
        public string SWIFT_Code { get; set; }
        public int Account_Type { get; set; }
        public string Account_No_ { get; set; }
        public int G_L_Posting_Factor { get; set; }
        public System.DateTime Absence_From_Date { get; set; }
        public System.DateTime Absence_To_Date { get; set; }
        public string ACF_Payment_Purpose { get; set; }
        public byte Transferred_Holiday { get; set; }
        public string ACF_ID { get; set; }
        public byte Used_Transferred_Holiday { get; set; }
    }
}
