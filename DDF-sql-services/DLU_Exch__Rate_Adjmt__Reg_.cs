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
    
    public partial class DLU_Exch__Rate_Adjmt__Reg_
    {
        public byte[] timestamp { get; set; }
        public int No_ { get; set; }
        public System.DateTime Creation_Date { get; set; }
        public int Account_Type { get; set; }
        public string Posting_Group { get; set; }
        public string Currency_Code { get; set; }
        public decimal Currency_Factor { get; set; }
        public decimal Adjusted_Base { get; set; }
        public decimal Adjusted_Base__LCY_ { get; set; }
        public decimal Adjusted_Amt___LCY_ { get; set; }
        public decimal Adjusted_Base__Add__Curr__ { get; set; }
        public decimal Adjusted_Amt___Add__Curr__ { get; set; }
    }
}
