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
    
    public partial class DLU_VAT_Posting_Setup
    {
        public byte[] timestamp { get; set; }
        public string VAT_Bus__Posting_Group { get; set; }
        public string VAT_Prod__Posting_Group { get; set; }
        public int VAT_Calculation_Type { get; set; }
        public decimal VAT__ { get; set; }
        public int Unrealized_VAT_Type { get; set; }
        public byte Adjust_for_Payment_Discount { get; set; }
        public string Sales_VAT_Account { get; set; }
        public string Sales_VAT_Unreal__Account { get; set; }
        public string Purchase_VAT_Account { get; set; }
        public string Purch__VAT_Unreal__Account { get; set; }
        public string Reverse_Chrg__VAT_Acc_ { get; set; }
        public string Reverse_Chrg__VAT_Unreal__Acc_ { get; set; }
        public string VAT_Identifier { get; set; }
    }
}
