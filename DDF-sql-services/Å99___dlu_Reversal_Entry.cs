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
    
    public partial class Å99___dlu_Reversal_Entry
    {
        public byte[] timestamp { get; set; }
        public int Line_No_ { get; set; }
        public int Entry_Type { get; set; }
        public int Entry_No_ { get; set; }
        public int G_L_Register_No_ { get; set; }
        public string Source_Code { get; set; }
        public string Journal_Batch_Name { get; set; }
        public int Transaction_No_ { get; set; }
        public int Source_Type { get; set; }
        public string Source_No_ { get; set; }
        public string Currency_Code { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal Debit_Amount { get; set; }
        public decimal Credit_Amount { get; set; }
        public decimal Amount__LCY_ { get; set; }
        public decimal Debit_Amount__LCY_ { get; set; }
        public decimal Credit_Amount__LCY_ { get; set; }
        public decimal VAT_Amount { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public int Document_Type { get; set; }
        public string Document_No_ { get; set; }
        public string Account_No_ { get; set; }
        public string Account_Name { get; set; }
        public int Bal__Account_Type { get; set; }
        public string Bal__Account_No_ { get; set; }
        public int FA_Posting_Category { get; set; }
        public int FA_Posting_Type { get; set; }
        public int Reversal_Type { get; set; }
    }
}
