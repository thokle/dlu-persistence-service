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
    
    public partial class DLU_Pmt__Ledger_Entry_Proc__Entry
    {
        public byte[] timestamp { get; set; }
        public string Jnl__Template_Name { get; set; }
        public string Jnl__Batch_Name { get; set; }
        public int Jnl__Line_No_ { get; set; }
        public int Payment_Ledger_Entry_No_ { get; set; }
        public int Entry_No_ { get; set; }
        public string User_ID { get; set; }
        public string Procuration_Group_Code { get; set; }
        public decimal Allocation__ { get; set; }
        public int Sequence { get; set; }
        public string Procuration_Department { get; set; }
        public string Bank_Account_No_ { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime Time { get; set; }
    }
}
