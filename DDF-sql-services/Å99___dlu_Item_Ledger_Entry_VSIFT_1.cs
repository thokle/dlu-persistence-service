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
    
    public partial class Å99___dlu_Item_Ledger_Entry_VSIFT_1
    {
        public string Item_No_ { get; set; }
        public int Entry_Type { get; set; }
        public string Variant_Code { get; set; }
        public byte Drop_Shipment { get; set; }
        public string Location_Code { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public Nullable<long> C_Cnt { get; set; }
        public Nullable<decimal> SUM_Quantity { get; set; }
        public Nullable<decimal> SUM_Invoiced_Quantity { get; set; }
    }
}
