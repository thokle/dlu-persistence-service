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
    
    public partial class Å99___dlu_Handled_IC_Outbox_Purch__Line
    {
        public byte[] timestamp { get; set; }
        public int IC_Transaction_No_ { get; set; }
        public string IC_Partner_Code { get; set; }
        public int Transaction_Source { get; set; }
        public int Line_No_ { get; set; }
        public int Document_Type { get; set; }
        public string Document_No_ { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Direct_Unit_Cost { get; set; }
        public decimal Line_Discount_Amount { get; set; }
        public decimal Amount_Including_VAT { get; set; }
        public string Job_No_ { get; set; }
        public decimal Indirect_Cost__ { get; set; }
        public byte Drop_Shipment { get; set; }
        public string Currency_Code { get; set; }
        public decimal VAT_Base_Amount { get; set; }
        public decimal Unit_Cost { get; set; }
        public decimal Line_Amount { get; set; }
        public int IC_Partner_Ref__Type { get; set; }
        public string IC_Partner_Reference { get; set; }
        public System.DateTime Promised_Receipt_Date { get; set; }
    }
}
