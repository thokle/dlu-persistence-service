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
    
    public partial class DLU_Job_Budget_Line
    {
        public byte[] timestamp { get; set; }
        public string Job_No_ { get; set; }
        public string Phase_Code { get; set; }
        public string Task_Code { get; set; }
        public string Step_Code { get; set; }
        public int Type { get; set; }
        public string No_ { get; set; }
        public string Variant_Code { get; set; }
        public System.DateTime Starting_Date { get; set; }
        public string Description { get; set; }
        public decimal Direct_Unit_Cost { get; set; }
        public decimal Unit_Cost { get; set; }
        public decimal Unit_Price { get; set; }
        public string Customer_Price_Group { get; set; }
        public string User_ID { get; set; }
    }
}