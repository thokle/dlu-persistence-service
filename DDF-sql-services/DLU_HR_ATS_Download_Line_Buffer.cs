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
    
    public partial class DLU_HR_ATS_Download_Line_Buffer
    {
        public byte[] timestamp { get; set; }
        public int ID { get; set; }
        public string No_ { get; set; }
        public string Application_ID { get; set; }
        public string Company_ID { get; set; }
        public string Source_ID { get; set; }
        public string Question_Type { get; set; }
        public string Answer { get; set; }
        public string Parent_Source_ID { get; set; }
        public string File_Name { get; set; }
        public byte[] Blob_File { get; set; }
        public byte Is_Questionnaire { get; set; }
        public string Questionnaire_Code { get; set; }
        public int Questionnaire_Line_No_ { get; set; }
        public string Batch_ID { get; set; }
        public string File_Extension { get; set; }
        public byte Transfered { get; set; }
        public string Log_Text { get; set; }
    }
}
