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
    
    public partial class DLU_Maintenance_Ledger_Entry
    {
        public byte[] timestamp { get; set; }
        public int Entry_No_ { get; set; }
        public int G_L_Entry_No_ { get; set; }
        public string FA_No_ { get; set; }
        public System.DateTime FA_Posting_Date { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public int Document_Type { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Document_No_ { get; set; }
        public string External_Document_No_ { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal Debit_Amount { get; set; }
        public decimal Credit_Amount { get; set; }
        public decimal Quantity { get; set; }
        public string FA_No__Budgeted_FA_No_ { get; set; }
        public string FA_Subclass_Code { get; set; }
        public string FA_Location_Code { get; set; }
        public string FA_Posting_Group { get; set; }
        public string Global_Dimension_1_Code { get; set; }
        public string Global_Dimension_2_Code { get; set; }
        public string Location_Code { get; set; }
        public string User_ID { get; set; }
        public string Journal_Batch_Name { get; set; }
        public string Source_Code { get; set; }
        public string Reason_Code { get; set; }
        public int Transaction_No_ { get; set; }
        public int Bal__Account_Type { get; set; }
        public string Bal__Account_No_ { get; set; }
        public decimal VAT_Amount { get; set; }
        public int Gen__Posting_Type { get; set; }
        public string Gen__Bus__Posting_Group { get; set; }
        public string Gen__Prod__Posting_Group { get; set; }
        public string FA_Class_Code { get; set; }
        public string Depreciation_Book_Code { get; set; }
        public decimal FA_Exchange_Rate { get; set; }
        public decimal Amount__LCY_ { get; set; }
        public string Maintenance_Code { get; set; }
        public byte Correction { get; set; }
        public byte Index_Entry { get; set; }
        public byte Automatic_Entry { get; set; }
        public string No__Series { get; set; }
        public string Tax_Area_Code { get; set; }
        public byte Tax_Liable { get; set; }
        public string Tax_Group_Code { get; set; }
        public byte Use_Tax { get; set; }
        public string VAT_Bus__Posting_Group { get; set; }
        public string VAT_Prod__Posting_Group { get; set; }
        public byte Reversed { get; set; }
        public int Reversed_by_Entry_No_ { get; set; }
        public int Reversed_Entry_No_ { get; set; }
    }
}