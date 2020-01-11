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
    
    public partial class DLU_Detailed_Vendor_Ledg__Entry
    {
        public byte[] timestamp { get; set; }
        public int Entry_No_ { get; set; }
        public int Vendor_Ledger_Entry_No_ { get; set; }
        public int Entry_Type { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public int Document_Type { get; set; }
        public string Document_No_ { get; set; }
        public decimal Amount { get; set; }
        public decimal Amount__LCY_ { get; set; }
        public string Vendor_No_ { get; set; }
        public string Currency_Code { get; set; }
        public string User_ID { get; set; }
        public string Source_Code { get; set; }
        public int Transaction_No_ { get; set; }
        public string Journal_Batch_Name { get; set; }
        public string Reason_Code { get; set; }
        public decimal Debit_Amount { get; set; }
        public decimal Credit_Amount { get; set; }
        public decimal Debit_Amount__LCY_ { get; set; }
        public decimal Credit_Amount__LCY_ { get; set; }
        public System.DateTime Initial_Entry_Due_Date { get; set; }
        public string Initial_Entry_Global_Dim__1 { get; set; }
        public string Initial_Entry_Global_Dim__2 { get; set; }
        public string Gen__Bus__Posting_Group { get; set; }
        public string Gen__Prod__Posting_Group { get; set; }
        public byte Use_Tax { get; set; }
        public string VAT_Bus__Posting_Group { get; set; }
        public string VAT_Prod__Posting_Group { get; set; }
        public int Initial_Document_Type { get; set; }
        public int Applied_Vend__Ledger_Entry_No_ { get; set; }
        public byte Unapplied { get; set; }
        public int Unapplied_by_Entry_No_ { get; set; }
        public decimal Remaining_Pmt__Disc__Possible { get; set; }
        public decimal Max__Payment_Tolerance { get; set; }
        public string Tax_Jurisdiction_Code { get; set; }
    }
}