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
    
    public partial class DLU_Tax_Detail
    {
        public byte[] timestamp { get; set; }
        public string Tax_Jurisdiction_Code { get; set; }
        public string Tax_Group_Code { get; set; }
        public int Tax_Type { get; set; }
        public System.DateTime Effective_Date { get; set; }
        public decimal Maximum_Amount_Qty_ { get; set; }
        public decimal Tax_Below_Maximum { get; set; }
        public decimal Tax_Above_Maximum { get; set; }
        public byte Calculate_Tax_on_Tax { get; set; }
    }
}
