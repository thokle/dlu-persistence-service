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
    
    public partial class DLU_Adjust_Exchange_Rate_Buffer
    {
        public byte[] timestamp { get; set; }
        public string Currency_Code { get; set; }
        public string Posting_Group { get; set; }
        public int Dimension_Entry_No_ { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public decimal AdjBase { get; set; }
        public decimal AdjBaseLCY { get; set; }
        public decimal AdjAmount { get; set; }
        public decimal TotalGainsAmount { get; set; }
        public decimal TotalLossesAmount { get; set; }
    }
}