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
    
    public partial class DLU_Job_Scheduler_Setup
    {
        public byte[] timestamp { get; set; }
        public string ID { get; set; }
        public string Description { get; set; }
        public byte Enabled { get; set; }
        public int Object_Type { get; set; }
        public int Object_No_ { get; set; }
        public string Object_Name { get; set; }
        public System.DateTime Last_Date_Checked { get; set; }
        public System.DateTime Last_Time_Checked { get; set; }
        public int Time_Between_Check { get; set; }
        public int Unit_of_Measure { get; set; }
        public System.DateTime Next_Check_Date { get; set; }
        public System.DateTime Next_Check_Time { get; set; }
        public int Run_Status { get; set; }
        public int Error_Handling { get; set; }
        public string Message_Text { get; set; }
        public byte Valid_on_Sundays { get; set; }
        public byte Valid_on_Mondays { get; set; }
        public byte Valid_on_Tuesdays { get; set; }
        public byte Valid_on_Wednesdays { get; set; }
        public byte Valid_on_Thursdays { get; set; }
        public byte Valid_on_Fridays { get; set; }
        public byte Valid_on_Saturdays { get; set; }
        public System.DateTime Starting_Time { get; set; }
        public System.DateTime Ending_Time { get; set; }
    }
}
