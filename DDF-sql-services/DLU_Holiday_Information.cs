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
    
    public partial class DLU_Holiday_Information
    {
        public byte[] timestamp { get; set; }
        public string Primary_Key { get; set; }
        public string Holiday_Absence_Code { get; set; }
        public decimal Holiday_Factor { get; set; }
        public int Holiday_Accumulation_Year { get; set; }
        public decimal Holiday_days_this_year { get; set; }
        public decimal Holiday_days_last_year { get; set; }
        public decimal Holiday_days_preceding_year { get; set; }
        public string Payment_Vacation_Card { get; set; }
        public byte Holiday_on_Weekday_Surplus { get; set; }
        public int Add__Holiday_Seniority { get; set; }
        public decimal Number_of_Add__Holidays { get; set; }
        public string Absence_Code_for_Add__Holiday { get; set; }
        public string Pay_Type_for_Add__Holiday { get; set; }
        public decimal Netto_Holiday_Payment_Limit { get; set; }
        public byte Holiday_Pay_Liability { get; set; }
        public byte Holiday_Bonus_Liabillity { get; set; }
        public string Holiday_Pay_Liability_Pay_Type { get; set; }
        public string Holiday_Bonus_Liabil__Pay_Type { get; set; }
        public string Holiday_Pay_Depr__Pay_Type { get; set; }
        public string Holdiay_Bonus_Depr__Pay_Type { get; set; }
        public byte SH_Surplus_Term__Empl_ { get; set; }
        public byte SH_Surplus_Ending_of_Year { get; set; }
        public int SH_Surplus_Ending_Date { get; set; }
        public byte Use_FV_Setup { get; set; }
        public string Pay_Type_for_open__bal__Wage { get; set; }
        public string Pay_Type_for_open__bal__Salary { get; set; }
        public string Pay_Type_for_Holiday_Bonus { get; set; }
        public string Jnl_Batch_Name_Term__Salary { get; set; }
        public string Abs_Code_Holiday_Term__Salary { get; set; }
        public string Abs_Code_Holiday_Card_T__Sal_ { get; set; }
        public string Pay_Type_Holiday_Days { get; set; }
        public string Pay_Type_Holiday_Hours { get; set; }
    }
}
