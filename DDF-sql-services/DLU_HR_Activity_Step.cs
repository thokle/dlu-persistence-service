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
    
    public partial class DLU_HR_Activity_Step
    {
        public byte[] timestamp { get; set; }
        public string Activity_Code { get; set; }
        public int Step_No_ { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public string Date_Formula { get; set; }
        public string Communication_Template_Code { get; set; }
        public byte Send_Notification { get; set; }
        public int Recipient_Type { get; set; }
        public string Extern_E_mail_address { get; set; }
    }
}
