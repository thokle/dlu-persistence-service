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
    
    public partial class DLU_NemRefusion_Payment_Buffer
    {
        public byte[] timestamp { get; set; }
        public int Line_No_ { get; set; }
        public System.DateTime Import_Date { get; set; }
        public System.DateTime Import_Time { get; set; }
        public string employee_source_identification { get; set; }
        public string Employee_No_ { get; set; }
        public string udbetalingDato { get; set; }
        public string udbetalingstypeKode { get; set; }
        public string valutaKode { get; set; }
        public string monetaerBeloeb { get; set; }
        public string periodeTilDato { get; set; }
        public string periodeFraDato { get; set; }
        public string sick_leave_id { get; set; }
        public string company_source_identification { get; set; }
        public string payment_specification_id { get; set; }
        public string Log_Entry_Batch_ID { get; set; }
        public int Report_Batch_ID { get; set; }
        public byte Transfered { get; set; }
    }
}
