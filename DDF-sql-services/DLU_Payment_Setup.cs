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
    
    public partial class DLU_Payment_Setup
    {
        public byte[] timestamp { get; set; }
        public string Primary_Key { get; set; }
        public byte Synchronize_with_Vendor { get; set; }
        public string Vendor_Payment_Group_Code { get; set; }
        public string FIK_GIRO_No_ { get; set; }
        public string IK_Card_Type { get; set; }
        public int UPR_No___Min__ { get; set; }
        public int UPR_No___Max__ { get; set; }
        public byte[] File_Dialog { get; set; }
        public string Version__Setup_ { get; set; }
        public byte Check_before_Post__Purch_Doc_ { get; set; }
        public string Customer_Account_Statement_No_ { get; set; }
        public int Additional_Payment_Mehods { get; set; }
        public int Move_Pmt__Discount_Date { get; set; }
        public string Payment_Nos_ { get; set; }
        public string Currency_Rates_Direct { get; set; }
        public string FI_Advice_Direct { get; set; }
        public byte Individual_Logon__Currency_ { get; set; }
        public byte Individual_Logon__Acc_Stmt__ { get; set; }
        public byte Individual_Logon__FIK_GIK_ { get; set; }
        public byte Individual_Logon__Send_Pmts__ { get; set; }
        public string Alt__bet_metode_konto_ovf_ { get; set; }
    }
}
