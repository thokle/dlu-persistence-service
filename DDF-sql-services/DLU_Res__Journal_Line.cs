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
    
    public partial class DLU_Res__Journal_Line
    {
        public byte[] timestamp { get; set; }
        public string Journal_Template_Name { get; set; }
        public string Journal_Batch_Name { get; set; }
        public int Line_No_ { get; set; }
        public int Entry_Type { get; set; }
        public string Document_No_ { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Resource_No_ { get; set; }
        public string Resource_Group_No_ { get; set; }
        public string Description { get; set; }
        public string Work_Type_Code { get; set; }
        public string Job_No_ { get; set; }
        public string Unit_of_Measure_Code { get; set; }
        public decimal Quantity { get; set; }
        public decimal Direct_Unit_Cost { get; set; }
        public decimal Unit_Cost { get; set; }
        public decimal Total_Cost { get; set; }
        public decimal Unit_Price { get; set; }
        public decimal Total_Price { get; set; }
        public string Shortcut_Dimension_1_Code { get; set; }
        public string Shortcut_Dimension_2_Code { get; set; }
        public string Source_Code { get; set; }
        public byte Chargeable { get; set; }
        public string Reason_Code { get; set; }
        public int Recurring_Method { get; set; }
        public System.DateTime Expiration_Date { get; set; }
        public string Recurring_Frequency { get; set; }
        public string Gen__Bus__Posting_Group { get; set; }
        public string Gen__Prod__Posting_Group { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string External_Document_No_ { get; set; }
        public string Posting_No__Series { get; set; }
        public int Source_Type { get; set; }
        public string Source_No_ { get; set; }
        public decimal Qty__per_Unit_of_Measure { get; set; }
    }
}
