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
    
    public partial class DLU_PDF_Setup
    {
        public byte[] timestamp { get; set; }
        public string Key { get; set; }
        public byte Active { get; set; }
        public byte Enable_Wizard { get; set; }
        public int Statement_Report_ID { get; set; }
        public byte Attach_Due_Docs__Statement_ { get; set; }
        public byte Attach_Period_Docs__Statement_ { get; set; }
        public byte Include_Document_Contact_Email { get; set; }
        public byte Wizard_Contact_Lookup { get; set; }
        public int Email_Program { get; set; }
        public byte Start_Wizard_during_Posting { get; set; }
        public int SMTP_Sender_Priority_1 { get; set; }
        public int SMTP_Sender_Priority_2 { get; set; }
        public string SMTP_Server { get; set; }
        public string SMTP_Sender_Email { get; set; }
        public string Fixed_bccEmail { get; set; }
        public string SMTP_Sendername { get; set; }
        public int SMTP_Authentication { get; set; }
        public string SMTP_User_ID { get; set; }
        public string SMTP_Password { get; set; }
        public byte bccEmail_to_UserID { get; set; }
        public string SMTP_Reply_to_Email { get; set; }
        public string SMTP_Reply_to_Name { get; set; }
        public int SMTP_Server_Port { get; set; }
        public byte SMTP_Secure_Connection { get; set; }
        public int PDF_Wait__sec_ { get; set; }
        public int Bullzip_Wait__millisec_ { get; set; }
        public string Email_Attachment { get; set; }
        public string Default_Language_Code { get; set; }
        public byte Wizard_Text_Editable { get; set; }
        public byte Let_the_Wizard_go_in_ring { get; set; }
        public byte Wizard_Hide_Internal_Email { get; set; }
        public int PDF_Solution { get; set; }
        public int PDF_Compatibility { get; set; }
        public byte PDF_A_1b { get; set; }
        public int PDF_Background_Solution { get; set; }
        public byte Use_Embedded_Attachments { get; set; }
        public string Bullzip_Licensefile { get; set; }
        public int Signature_Store_Location { get; set; }
        public string Signature_Password { get; set; }
        public string Signature_Reason { get; set; }
        public string Signature_Certificate_File { get; set; }
        public string Signature_Thumb_Print { get; set; }
        public int Signature_Store_Name { get; set; }
        public byte Signature_Show { get; set; }
        public int Bullzip_Edition { get; set; }
        public int Reminder_Report_ID { get; set; }
        public byte Attach_Docs__Reminder_ { get; set; }
        public int Fin__Charge_Memo_Report_ID { get; set; }
        public byte Attach_Docs__FCM_ { get; set; }
        public byte Include_OIOUBL_Documents { get; set; }
        public byte Autocreate_OIOUBL_Documents { get; set; }
        public byte Delete_OIOUBL_after_sent { get; set; }
        public int Invoice_Report_ID { get; set; }
        public string PDF_Manual { get; set; }
    }
}