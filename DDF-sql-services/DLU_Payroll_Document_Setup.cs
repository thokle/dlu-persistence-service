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
    
    public partial class DLU_Payroll_Document_Setup
    {
        public byte[] timestamp { get; set; }
        public int Document_Type { get; set; }
        public int Storage_Type { get; set; }
        public string Storage_Location { get; set; }
        public string Temp__Storage_Location { get; set; }
        public int Encryption_Key_Length { get; set; }
        public int File_Naming { get; set; }
        public byte Subdir__per_Payroll_Posting { get; set; }
        public int Field_1_Replacement { get; set; }
        public int Field_2_Replacement { get; set; }
        public int Field_3_Replacement { get; set; }
        public int Field_4_Replacement { get; set; }
        public int Field_5_Replacement { get; set; }
        public int Field_6_Replacement { get; set; }
        public int Field_7_Replacement { get; set; }
        public int Field_8_Replacement { get; set; }
        public int Field_9_Replacement { get; set; }
        public string PDF_Program { get; set; }
        public int Shell_Command_Format { get; set; }
        public int Mail_Server_Type { get; set; }
        public string SMTP_Mail_Server { get; set; }
        public int SMTP_Mail_Server_Port { get; set; }
        public string Mail_Sender_Address { get; set; }
        public string Report_Description_Location { get; set; }
        public string Report_Object_Text_File { get; set; }
        public byte Colored_Background_Header { get; set; }
        public byte Colored_Background_Body { get; set; }
        public byte Document_Debugging { get; set; }
        public string Mail_Sender_Password { get; set; }
        public byte Encrypted_Connection { get; set; }
    }
}