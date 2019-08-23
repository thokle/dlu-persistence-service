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
    
    public partial class Å99___dlu_Transfer_Line
    {
        public byte[] timestamp { get; set; }
        public string Document_No_ { get; set; }
        public int Line_No_ { get; set; }
        public string Item_No_ { get; set; }
        public decimal Quantity { get; set; }
        public string Unit_of_Measure { get; set; }
        public decimal Qty__to_Ship { get; set; }
        public decimal Qty__to_Receive { get; set; }
        public decimal Quantity_Shipped { get; set; }
        public decimal Quantity_Received { get; set; }
        public int Status { get; set; }
        public string Shortcut_Dimension_1_Code { get; set; }
        public string Shortcut_Dimension_2_Code { get; set; }
        public string Description { get; set; }
        public string Gen__Prod__Posting_Group { get; set; }
        public string Inventory_Posting_Group { get; set; }
        public decimal Quantity__Base_ { get; set; }
        public decimal Outstanding_Qty___Base_ { get; set; }
        public decimal Qty__to_Ship__Base_ { get; set; }
        public decimal Qty__Shipped__Base_ { get; set; }
        public decimal Qty__to_Receive__Base_ { get; set; }
        public decimal Qty__Received__Base_ { get; set; }
        public decimal Qty__per_Unit_of_Measure { get; set; }
        public string Unit_of_Measure_Code { get; set; }
        public decimal Outstanding_Quantity { get; set; }
        public decimal Gross_Weight { get; set; }
        public decimal Net_Weight { get; set; }
        public decimal Unit_Volume { get; set; }
        public string Variant_Code { get; set; }
        public decimal Units_per_Parcel { get; set; }
        public string Description_2 { get; set; }
        public string In_Transit_Code { get; set; }
        public decimal Qty__in_Transit { get; set; }
        public decimal Qty__in_Transit__Base_ { get; set; }
        public string Transfer_from_Code { get; set; }
        public string Transfer_to_Code { get; set; }
        public System.DateTime Shipment_Date { get; set; }
        public System.DateTime Receipt_Date { get; set; }
        public int Derived_From_Line_No_ { get; set; }
        public string Shipping_Agent_Code { get; set; }
        public string Shipping_Agent_Service_Code { get; set; }
        public string Shipping_Time { get; set; }
        public string Item_Category_Code { get; set; }
        public string Product_Group_Code { get; set; }
        public byte Completely_Shipped { get; set; }
        public byte Completely_Received { get; set; }
        public string Outbound_Whse__Handling_Time { get; set; }
        public string Inbound_Whse__Handling_Time { get; set; }
        public string Transfer_from_Bin_Code { get; set; }
        public string Transfer_To_Bin_Code { get; set; }
        public int Planning_Flexibility { get; set; }
    }
}
