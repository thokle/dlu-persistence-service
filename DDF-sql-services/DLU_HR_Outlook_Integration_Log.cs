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
    
    public partial class DLU_HR_Outlook_Integration_Log
    {
        public byte[] timestamp { get; set; }
        public int Entry_No_ { get; set; }
        public int Record_Type { get; set; }
        public string Record_No_ { get; set; }
        public string Record_Description { get; set; }
        public byte[] Outlook_Item_ID { get; set; }
        public string Outlook_Item_Description { get; set; }
        public System.DateTime Occurrence_Date { get; set; }
        public System.DateTime Occurrence_Time { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public string HR_Professional_Code { get; set; }
        public int Action { get; set; }
        public int No__of_Conflicting_Fields { get; set; }
        public string Outlook_Item_ID_Hash { get; set; }
        public int No__of_Unresolved_Fields { get; set; }
    }
}
