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
    
    public partial class DLU_Value_Entry_VSIFT_3
    {
        public string Item_No_ { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public int Item_Ledger_Entry_Type { get; set; }
        public int Entry_Type { get; set; }
        public string Item_Charge_No_ { get; set; }
        public string Location_Code { get; set; }
        public string Variant_Code { get; set; }
        public Nullable<long> C_Cnt { get; set; }
        public Nullable<decimal> SUM_Invoiced_Quantity { get; set; }
        public Nullable<decimal> SUM_Sales_Amount__Expected_ { get; set; }
        public Nullable<decimal> SUM_Sales_Amount__Actual_ { get; set; }
        public Nullable<decimal> SUM_Cost_Amount__Expected_ { get; set; }
        public Nullable<decimal> SUM_Cost_Amount__Actual_ { get; set; }
        public Nullable<decimal> SUM_Cost_Amount__Non_Invtbl__ { get; set; }
        public Nullable<decimal> SUM_Purchase_Amount__Actual_ { get; set; }
        public Nullable<decimal> SUM_Item_Ledger_Entry_Quantity { get; set; }
    }
}
