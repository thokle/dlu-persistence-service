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
    
    public partial class DLU_Daily_Schedule
    {
        public byte[] timestamp { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public System.DateTime Before_Scheduled_Begin { get; set; }
        public System.DateTime After_Scheduled_Begin { get; set; }
        public System.DateTime Before_Scheduled_End { get; set; }
        public System.DateTime After_Scheduled_End { get; set; }
    }
}
