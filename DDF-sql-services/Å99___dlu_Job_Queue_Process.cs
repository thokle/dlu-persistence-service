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
    
    public partial class Å99___dlu_Job_Queue_Process
    {
        public byte[] timestamp { get; set; }
        public int Session_ID { get; set; }
        public string User_ID { get; set; }
        public System.DateTime Last_Job_Processed_On { get; set; }
        public int Object_Type_Running { get; set; }
        public int Object_ID_Running { get; set; }
        public int Minimum_Job_Queue_Priority { get; set; }
        public int Maximum_Job_Queue_Priority { get; set; }
        public byte Active { get; set; }
    }
}
