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
    
    public partial class DLU_Finance_Charge_Terms
    {
        public byte[] timestamp { get; set; }
        public string Code { get; set; }
        public decimal Interest_Rate { get; set; }
        public decimal Minimum_Amount__LCY_ { get; set; }
        public decimal Additional_Fee__LCY_ { get; set; }
        public string Description { get; set; }
        public int Interest_Calculation_Method { get; set; }
        public int Interest_Period__Days_ { get; set; }
        public string Grace_Period { get; set; }
        public string Due_Date_Calculation { get; set; }
        public int Interest_Calculation { get; set; }
        public byte Post_Interest { get; set; }
        public byte Post_Additional_Fee { get; set; }
        public string Line_Description { get; set; }
    }
}
