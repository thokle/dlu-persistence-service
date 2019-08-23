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
    
    public partial class DLU_Currency
    {
        public byte[] timestamp { get; set; }
        public string Code { get; set; }
        public System.DateTime Last_Date_Modified { get; set; }
        public System.DateTime Last_Date_Adjusted { get; set; }
        public string Unrealized_Gains_Acc_ { get; set; }
        public string Realized_Gains_Acc_ { get; set; }
        public string Unrealized_Losses_Acc_ { get; set; }
        public string Realized_Losses_Acc_ { get; set; }
        public decimal Invoice_Rounding_Precision { get; set; }
        public int Invoice_Rounding_Type { get; set; }
        public decimal Amount_Rounding_Precision { get; set; }
        public decimal Unit_Amount_Rounding_Precision { get; set; }
        public string Description { get; set; }
        public string Amount_Decimal_Places { get; set; }
        public string Unit_Amount_Decimal_Places { get; set; }
        public string Realized_G_L_Gains_Account { get; set; }
        public string Realized_G_L_Losses_Account { get; set; }
        public decimal Appln__Rounding_Precision { get; set; }
        public byte EMU_Currency { get; set; }
        public decimal Currency_Factor { get; set; }
        public string Residual_Gains_Account { get; set; }
        public string Residual_Losses_Account { get; set; }
        public string Conv__LCY_Rndg__Debit_Acc_ { get; set; }
        public string Conv__LCY_Rndg__Credit_Acc_ { get; set; }
        public decimal Max__VAT_Difference_Allowed { get; set; }
        public int VAT_Rounding_Type { get; set; }
        public decimal Payment_Tolerance__ { get; set; }
        public decimal Max__Payment_Tolerance_Amount { get; set; }
    }
}
