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
    
    public partial class DLU_Job_Scheduler_Log
    {
        public byte[] timestamp { get; set; }
        public int Entry_No_ { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime Time { get; set; }
        public string Job_Scheduler_ID { get; set; }
        public string Message_Text { get; set; }
        public byte Error_Occurred { get; set; }
    }
}
