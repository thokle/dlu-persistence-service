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
    
    public partial class Å99___dlu_Warehouse_Receipt_Line
    {
        public byte[] timestamp { get; set; }
        public string No_ { get; set; }
        public int Line_No_ { get; set; }
        public int Source_Type { get; set; }
        public int Source_Subtype { get; set; }
        public string Source_No_ { get; set; }
        public int Source_Line_No_ { get; set; }
        public int Source_Document { get; set; }
        public string Location_Code { get; set; }
        public string Shelf_No_ { get; set; }
        public string Bin_Code { get; set; }
        public string Zone_Code { get; set; }
        public string Item_No_ { get; set; }
        public decimal Quantity { get; set; }
        public decimal Qty___Base_ { get; set; }
        public decimal Qty__Outstanding { get; set; }
        public decimal Qty__Outstanding__Base_ { get; set; }
        public decimal Qty__to_Receive { get; set; }
        public decimal Qty__to_Receive__Base_ { get; set; }
        public decimal Qty__Received { get; set; }
        public decimal Qty__Received__Base_ { get; set; }
        public string Unit_of_Measure_Code { get; set; }
        public decimal Qty__per_Unit_of_Measure { get; set; }
        public string Variant_Code { get; set; }
        public string Description { get; set; }
        public string Description_2 { get; set; }
        public int Status { get; set; }
        public int Sorting_Sequence_No_ { get; set; }
        public System.DateTime Due_Date { get; set; }
        public System.DateTime Starting_Date { get; set; }
        public decimal Cubage { get; set; }
        public decimal Weight { get; set; }
        public byte Not_upd__by_Src__Doc__Post_ { get; set; }
        public int Posting_from_Whse__Ref_ { get; set; }
        public decimal Qty__to_Cross_Dock { get; set; }
        public decimal Qty__to_Cross_Dock__Base_ { get; set; }
        public string Cross_Dock_Zone_Code { get; set; }
        public string Cross_Dock_Bin_Code { get; set; }
    }
}
