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
    
    public partial class DLU_Opportunity_Entry
    {
        public byte[] timestamp { get; set; }
        public int Entry_No_ { get; set; }
        public string Opportunity_No_ { get; set; }
        public string Sales_Cycle_Code { get; set; }
        public int Sales_Cycle_Stage { get; set; }
        public string Contact_No_ { get; set; }
        public string Contact_Company_No_ { get; set; }
        public string Salesperson_Code { get; set; }
        public string Campaign_No_ { get; set; }
        public System.DateTime Date_of_Change { get; set; }
        public byte Active { get; set; }
        public System.DateTime Date_Closed { get; set; }
        public decimal Days_Open { get; set; }
        public int Action_Taken { get; set; }
        public decimal Estimated_Value__LCY_ { get; set; }
        public decimal Calcd__Current_Value__LCY_ { get; set; }
        public decimal Completed__ { get; set; }
        public decimal Chances_of_Success__ { get; set; }
        public decimal Probability__ { get; set; }
        public string Close_Opportunity_Code { get; set; }
        public int Previous_Sales_Cycle_Stage { get; set; }
        public System.DateTime Estimated_Close_Date { get; set; }
    }
}
