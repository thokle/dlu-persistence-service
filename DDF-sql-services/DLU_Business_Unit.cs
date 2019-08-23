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
    
    public partial class DLU_Business_Unit
    {
        public byte[] timestamp { get; set; }
        public string Code { get; set; }
        public byte Consolidate { get; set; }
        public decimal Consolidation__ { get; set; }
        public System.DateTime Starting_Date { get; set; }
        public System.DateTime Ending_Date { get; set; }
        public decimal Income_Currency_Factor { get; set; }
        public decimal Balance_Currency_Factor { get; set; }
        public string Exch__Rate_Losses_Acc_ { get; set; }
        public string Exch__Rate_Gains_Acc_ { get; set; }
        public string Residual_Account { get; set; }
        public decimal Last_Balance_Currency_Factor { get; set; }
        public string Name { get; set; }
        public string Company_Name { get; set; }
        public string Currency_Code { get; set; }
        public string Comp__Exch__Rate_Gains_Acc_ { get; set; }
        public string Comp__Exch__Rate_Losses_Acc_ { get; set; }
        public string Equity_Exch__Rate_Gains_Acc_ { get; set; }
        public string Equity_Exch__Rate_Losses_Acc_ { get; set; }
        public string Minority_Exch__Rate_Gains_Acc_ { get; set; }
        public string Minority_Exch__Rate_Losses_Acc { get; set; }
        public int Currency_Exchange_Rate_Table { get; set; }
        public int Data_Source { get; set; }
        public int File_Format { get; set; }
    }
}
