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
    
    public partial class DLU_Time_Type
    {
        public byte[] timestamp { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Scheduled_Time { get; set; }
        public int Scheduled_Time_Delimitation { get; set; }
        public string Pay_Type_No_ { get; set; }
        public string Statutory_Hol__Calendar_Code { get; set; }
        public byte Create_on_Statutory_Holidays { get; set; }
        public decimal Factor { get; set; }
        public string Search_Name { get; set; }
        public byte Transfer_to_Payroll { get; set; }
        public byte Transfer_Totals { get; set; }
        public byte Approval { get; set; }
        public string Actual_Hours_Begin { get; set; }
        public string Actual_Hours_End { get; set; }
        public byte Reverse_Sorting { get; set; }
        public string Time_Delimitation { get; set; }
        public string Scheduled_Begin_Delimitation { get; set; }
        public string Scheduled_End_Delimitation { get; set; }
        public string Actual_Time_Begin_Delimitation { get; set; }
        public string Actual_Time_End_Delimitation { get; set; }
        public string Cause_of_Absence_Code_Filter { get; set; }
        public System.DateTime Actual_hours_from { get; set; }
        public System.DateTime Actual_hours_to { get; set; }
        public byte Change_Sign { get; set; }
        public string Global_Dimension_1_Code { get; set; }
        public string Global_Dimension_2_Code { get; set; }
        public string Rounding_Method { get; set; }
        public string Rounding_Method_Begin { get; set; }
        public string Rounding_Method_End { get; set; }
        public System.DateTime Last_Date_Modified { get; set; }
        public int Type { get; set; }
        public int Time_Calculation { get; set; }
        public string Prod__Order_No_ { get; set; }
        public string Operation_No_ { get; set; }
        public string Item_No_ { get; set; }
        public string Routing_No_ { get; set; }
        public int Routing_Reference_No_ { get; set; }
        public string Job_No_ { get; set; }
        public string Phase_Code { get; set; }
        public string Task_Code { get; set; }
        public string Step_Code { get; set; }
        public int Calculation_Date { get; set; }
        public string Day_Filter { get; set; }
        public string Remove_from_Lookup_Form { get; set; }
        public byte Do_not_transfer_Absence { get; set; }
        public byte SeveralCOA { get; set; }
    }
}
