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
    
    public partial class DLU_VAT_Entry_VSIFT_1
    {
        public int Type { get; set; }
        public byte Closed { get; set; }
        public string VAT_Bus__Posting_Group { get; set; }
        public string VAT_Prod__Posting_Group { get; set; }
        public string Tax_Jurisdiction_Code { get; set; }
        public byte Use_Tax { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public Nullable<long> C_Cnt { get; set; }
        public Nullable<decimal> SUM_Base { get; set; }
        public Nullable<decimal> SUM_Amount { get; set; }
        public Nullable<decimal> SUM_Unrealized_Amount { get; set; }
        public Nullable<decimal> SUM_Unrealized_Base { get; set; }
        public Nullable<decimal> SUM_Additional_Currency_Base { get; set; }
        public Nullable<decimal> SUM_Additional_Currency_Amount { get; set; }
        public Nullable<decimal> SUM_Add__Currency_Unrealized_Amt_ { get; set; }
        public Nullable<decimal> SUM_Add__Currency_Unrealized_Base { get; set; }
        public Nullable<decimal> SUM_Remaining_Unrealized_Amount { get; set; }
    }
}
