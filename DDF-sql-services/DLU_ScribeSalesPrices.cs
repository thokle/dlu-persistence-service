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
    
    public partial class DLU_ScribeSalesPrices
    {
        public byte[] timestamp { get; set; }
        public System.Guid ID { get; set; }
        public string Item_No_ { get; set; }
        public System.Guid Price_Level_ID { get; set; }
        public string Customer_Price_Group { get; set; }
        public string Currency_Code { get; set; }
        public string Variant_Code { get; set; }
        public string Unit_of_Measure_Code { get; set; }
        public decimal Unit_Price { get; set; }
        public decimal Currency_Factor { get; set; }
        public decimal Qty__per_Unit_of_Measure { get; set; }
        public byte Sales_Price_Exists { get; set; }
        public byte Price_Includes_VAT { get; set; }
        public int VAT_Calculation_Type { get; set; }
        public System.DateTime ModifiedDatetime { get; set; }
    }
}