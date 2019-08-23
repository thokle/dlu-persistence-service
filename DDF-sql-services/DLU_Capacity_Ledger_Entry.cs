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
    
    public partial class DLU_Capacity_Ledger_Entry
    {
        public byte[] timestamp { get; set; }
        public int Entry_No_ { get; set; }
        public string No_ { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public int Type { get; set; }
        public string Document_No_ { get; set; }
        public string Description { get; set; }
        public string Operation_No_ { get; set; }
        public string Work_Center_No_ { get; set; }
        public decimal Quantity { get; set; }
        public decimal Setup_Time { get; set; }
        public decimal Run_Time { get; set; }
        public decimal Stop_Time { get; set; }
        public decimal Invoiced_Quantity { get; set; }
        public decimal Output_Quantity { get; set; }
        public decimal Scrap_Quantity { get; set; }
        public decimal Concurrent_Capacity { get; set; }
        public string Cap__Unit_of_Measure_Code { get; set; }
        public decimal Qty__per_Cap__Unit_of_Measure { get; set; }
        public string Global_Dimension_1_Code { get; set; }
        public string Global_Dimension_2_Code { get; set; }
        public byte Last_Output_Line { get; set; }
        public byte Completely_Invoiced { get; set; }
        public System.DateTime Starting_Time { get; set; }
        public System.DateTime Ending_Time { get; set; }
        public string Prod__Order_No_ { get; set; }
        public int Prod__Order_Line_No_ { get; set; }
        public string Routing_No_ { get; set; }
        public int Routing_Reference_No_ { get; set; }
        public string Item_No_ { get; set; }
        public string Variant_Code { get; set; }
        public string Unit_of_Measure_Code { get; set; }
        public decimal Qty__per_Unit_of_Measure { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string External_Document_No_ { get; set; }
        public string Stop_Code { get; set; }
        public string Scrap_Code { get; set; }
        public string Work_Center_Group_Code { get; set; }
        public string Work_Shift_Code { get; set; }
        public byte Subcontracting { get; set; }
    }
}
