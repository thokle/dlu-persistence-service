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
    
    public partial class DLU_Extended_Text_Header
    {
        public byte[] timestamp { get; set; }
        public int Table_Name { get; set; }
        public string No_ { get; set; }
        public string Language_Code { get; set; }
        public int Text_No_ { get; set; }
        public System.DateTime Starting_Date { get; set; }
        public System.DateTime Ending_Date { get; set; }
        public byte All_Language_Codes { get; set; }
        public byte Sales_Quote { get; set; }
        public byte Sales_Invoice { get; set; }
        public byte Sales_Order { get; set; }
        public byte Sales_Credit_Memo { get; set; }
        public byte Purchase_Quote { get; set; }
        public byte Purchase_Invoice { get; set; }
        public byte Purchase_Order { get; set; }
        public byte Purchase_Credit_Memo { get; set; }
        public byte Reminder { get; set; }
        public byte Finance_Charge_Memo { get; set; }
        public byte Sales_Blanket_Order { get; set; }
        public byte Purchase_Blanket_Order { get; set; }
        public byte Service_Order { get; set; }
        public byte Service_Quote { get; set; }
        public byte Sales_Return_Order { get; set; }
        public byte Purchase_Return_Order { get; set; }
    }
}
