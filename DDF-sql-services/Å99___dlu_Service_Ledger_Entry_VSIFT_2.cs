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
    
    public partial class Å99___dlu_Service_Ledger_Entry_VSIFT_2
    {
        public string Service_Contract_No_ { get; set; }
        public int Entry_No_ { get; set; }
        public int Entry_Type { get; set; }
        public int Type { get; set; }
        public byte Moved_from_Prepaid_Acc_ { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public byte Open { get; set; }
        public byte Prepaid { get; set; }
        public string Service_Item_No___Serviced_ { get; set; }
        public string Customer_No_ { get; set; }
        public string Contract_Group_Code { get; set; }
        public string Responsibility_Center { get; set; }
        public Nullable<long> C_Cnt { get; set; }
        public Nullable<decimal> SUM_Amount__LCY_ { get; set; }
        public Nullable<decimal> SUM_Cost_Amount { get; set; }
        public Nullable<decimal> SUM_Quantity { get; set; }
        public Nullable<decimal> SUM_Charged_Qty_ { get; set; }
        public Nullable<decimal> SUM_Contract_Disc__Amount { get; set; }
    }
}
