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
    
    public partial class DLU_Warranty_Ledger_Entry
    {
        public byte[] timestamp { get; set; }
        public int Entry_No_ { get; set; }
        public string Document_No_ { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Customer_No_ { get; set; }
        public string Ship_to_Code { get; set; }
        public string Bill_to_Customer_No_ { get; set; }
        public string Variant_Code__Serviced_ { get; set; }
        public string Service_Item_No___Serviced_ { get; set; }
        public string Item_No___Serviced_ { get; set; }
        public string Serial_No___Serviced_ { get; set; }
        public string Service_Item_Group__Serviced_ { get; set; }
        public string Service_Order_No_ { get; set; }
        public string Service_Contract_No_ { get; set; }
        public string Fault_Reason_Code { get; set; }
        public string Fault_Area_Code { get; set; }
        public string Fault_Code { get; set; }
        public string Symptom_Code { get; set; }
        public string Resolution_Code { get; set; }
        public int Type { get; set; }
        public string No_ { get; set; }
        public decimal Quantity { get; set; }
        public decimal Charged_Qty_ { get; set; }
        public string Work_Type_Code { get; set; }
        public string Unit_of_Measure_Code { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string Gen__Bus__Posting_Group { get; set; }
        public string Gen__Prod__Posting_Group { get; set; }
        public string Global_Dimension_1_Code { get; set; }
        public string Global_Dimension_2_Code { get; set; }
        public byte Open { get; set; }
        public string Vendor_No_ { get; set; }
        public string Vendor_Item_No_ { get; set; }
        public string Variant_Code { get; set; }
    }
}
