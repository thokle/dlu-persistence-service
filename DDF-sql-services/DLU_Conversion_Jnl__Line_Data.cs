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
    
    public partial class DLU_Conversion_Jnl__Line_Data
    {
        public byte[] timestamp { get; set; }
        public string Journal_Template_Name { get; set; }
        public string Journal_Batch_Name { get; set; }
        public int Line_No_ { get; set; }
        public int Row_No_ { get; set; }
        public int Column_No_ { get; set; }
        public string xlRowID { get; set; }
        public string xlColID { get; set; }
        public string Cell_Value_as_Text { get; set; }
        public string Comment { get; set; }
        public string Formula { get; set; }
        public byte Bold { get; set; }
        public byte Italic { get; set; }
        public byte Underline { get; set; }
        public string NumberFormat { get; set; }
        public byte Convertet { get; set; }
        public byte Changed { get; set; }
        public string Changed_By { get; set; }
        public byte Truncated { get; set; }
    }
}