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
    
    public partial class DLU_Standard_Task_Quality_Measure
    {
        public byte[] timestamp { get; set; }
        public string Standard_Task_Code { get; set; }
        public int Line_No_ { get; set; }
        public string Qlty_Measure_Code { get; set; }
        public string Description { get; set; }
        public decimal Min__Value { get; set; }
        public decimal Max__Value { get; set; }
        public decimal Mean_Tolerance { get; set; }
    }
}
