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
    
    public partial class Å99___dlu_VAT_Amount_Line
    {
        public byte[] timestamp { get; set; }
        public string VAT_Identifier { get; set; }
        public int VAT_Calculation_Type { get; set; }
        public string Tax_Group_Code { get; set; }
        public byte Use_Tax { get; set; }
        public byte Positive { get; set; }
        public decimal VAT__ { get; set; }
        public decimal VAT_Base { get; set; }
        public decimal VAT_Amount { get; set; }
        public decimal Amount_Including_VAT { get; set; }
        public decimal Line_Amount { get; set; }
        public decimal Inv__Disc__Base_Amount { get; set; }
        public decimal Invoice_Discount_Amount { get; set; }
        public decimal Quantity { get; set; }
        public byte Modified { get; set; }
        public decimal Calculated_VAT_Amount { get; set; }
        public decimal VAT_Difference { get; set; }
    }
}
