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
    
    public partial class DLU_IC_Outbox_Transaction
    {
        public byte[] timestamp { get; set; }
        public int Transaction_No_ { get; set; }
        public string IC_Partner_Code { get; set; }
        public int Transaction_Source { get; set; }
        public int Document_Type { get; set; }
        public int Source_Type { get; set; }
        public string Document_No_ { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public System.DateTime Document_Date { get; set; }
        public int Line_Action { get; set; }
    }
}
