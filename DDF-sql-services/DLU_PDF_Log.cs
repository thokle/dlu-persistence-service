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
    
    public partial class DLU_PDF_Log
    {
        public byte[] timestamp { get; set; }
        public int Entry_No_ { get; set; }
        public int Source_Type { get; set; }
        public string Source_No_ { get; set; }
        public int TableID { get; set; }
        public int Open_Document_Type { get; set; }
        public string Document_No_ { get; set; }
        public string Subject { get; set; }
        public System.DateTime Create_Date { get; set; }
        public System.DateTime Create_Time { get; set; }
        public string Create_By { get; set; }
        public string Error_Description { get; set; }
        public byte Error { get; set; }
    }
}
