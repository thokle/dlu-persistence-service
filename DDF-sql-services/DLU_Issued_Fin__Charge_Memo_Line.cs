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
    
    public partial class DLU_Issued_Fin__Charge_Memo_Line
    {
        public byte[] timestamp { get; set; }
        public string Finance_Charge_Memo_No_ { get; set; }
        public int Line_No_ { get; set; }
        public int Attached_to_Line_No_ { get; set; }
        public int Type { get; set; }
        public int Entry_No_ { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public System.DateTime Document_Date { get; set; }
        public System.DateTime Due_Date { get; set; }
        public int Document_Type { get; set; }
        public string Document_No_ { get; set; }
        public string Description { get; set; }
        public decimal Original_Amount { get; set; }
        public decimal Remaining_Amount { get; set; }
        public string No_ { get; set; }
        public decimal Amount { get; set; }
        public decimal Interest_Rate { get; set; }
        public string Gen__Prod__Posting_Group { get; set; }
        public decimal VAT__ { get; set; }
        public int VAT_Calculation_Type { get; set; }
        public decimal VAT_Amount { get; set; }
        public string Tax_Group_Code { get; set; }
        public string VAT_Prod__Posting_Group { get; set; }
        public string VAT_Identifier { get; set; }
        public string Account_Code { get; set; }
    }
}
