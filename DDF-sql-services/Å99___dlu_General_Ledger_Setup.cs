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
    
    public partial class Å99___dlu_General_Ledger_Setup
    {
        public byte[] timestamp { get; set; }
        public string Primary_Key { get; set; }
        public System.DateTime Allow_Posting_From { get; set; }
        public System.DateTime Allow_Posting_To { get; set; }
        public byte Register_Time { get; set; }
        public byte Pmt__Disc__Excl__VAT { get; set; }
        public byte Unrealized_VAT { get; set; }
        public byte Adjust_for_Payment_Disc_ { get; set; }
        public byte Mark_Cr__Memos_as_Corrections { get; set; }
        public int Local_Address_Format { get; set; }
        public decimal Inv__Rounding_Precision__LCY_ { get; set; }
        public int Inv__Rounding_Type__LCY_ { get; set; }
        public int Local_Cont__Addr__Format { get; set; }
        public string Bank_Account_Nos_ { get; set; }
        public byte Summarize_G_L_Entries { get; set; }
        public string Amount_Decimal_Places { get; set; }
        public string Unit_Amount_Decimal_Places { get; set; }
        public string Additional_Reporting_Currency { get; set; }
        public decimal VAT_Tolerance__ { get; set; }
        public byte EMU_Currency { get; set; }
        public string LCY_Code { get; set; }
        public int VAT_Exchange_Rate_Adjustment { get; set; }
        public decimal Amount_Rounding_Precision { get; set; }
        public decimal Unit_Amount_Rounding_Precision { get; set; }
        public decimal Appln__Rounding_Precision { get; set; }
        public string Global_Dimension_1_Code { get; set; }
        public string Global_Dimension_2_Code { get; set; }
        public string Shortcut_Dimension_1_Code { get; set; }
        public string Shortcut_Dimension_2_Code { get; set; }
        public string Shortcut_Dimension_3_Code { get; set; }
        public string Shortcut_Dimension_4_Code { get; set; }
        public string Shortcut_Dimension_5_Code { get; set; }
        public string Shortcut_Dimension_6_Code { get; set; }
        public string Shortcut_Dimension_7_Code { get; set; }
        public string Shortcut_Dimension_8_Code { get; set; }
        public decimal Max__VAT_Difference_Allowed { get; set; }
        public int VAT_Rounding_Type { get; set; }
        public int Pmt__Disc__Tolerance_Posting { get; set; }
        public string Payment_Discount_Grace_Period { get; set; }
        public decimal Payment_Tolerance__ { get; set; }
        public decimal Max__Payment_Tolerance_Amount { get; set; }
        public byte Adapt_Main_Menu_to_Permissions { get; set; }
        public System.DateTime Allow_G_L_Acc__Deletion_Before { get; set; }
        public byte Check_G_L_Account_Usage { get; set; }
        public int Payment_Tolerance_Posting { get; set; }
        public byte Pmt__Disc__Tolerance_Warning { get; set; }
        public byte Payment_Tolerance_Warning { get; set; }
        public int Last_IC_Transaction_No_ { get; set; }
        public int Bill_to_Sell_to_VAT_Calc_ { get; set; }
        public byte Print_VAT_specification_in_LCY { get; set; }
        public byte Global_Dim__Change_Blocked { get; set; }
        public string Heltids_konto { get; set; }
        public string Lønfaktor_DMA_konto_M_M { get; set; }
        public string Lønfaktor_DA_konto { get; set; }
        public string Lønfaktor_DMA_konto_U_M { get; set; }
        public string Kontingent_tekst_DMA { get; set; }
        public string Kontingent_tekst_DA { get; set; }
        public decimal Lønfaktor_DMA_konto___M_M { get; set; }
        public decimal Lønfaktor_DMA_konto___U_M { get; set; }
        public decimal Papir_faktor { get; set; }
        public decimal Heltids_faktor { get; set; }
        public decimal Lønfaktor_DMA { get; set; }
        public decimal Lønfaktor_DA { get; set; }
        public string Papirkonto { get; set; }
        public decimal Kreditrisiko_faktor { get; set; }
        public string Kreditrisiko_konto { get; set; }
        public decimal Grundkontingent_beløb { get; set; }
        public string Grundkontingent_konto { get; set; }
        public decimal Oplagskontingent_sats_1 { get; set; }
        public decimal Oplagskontingent_sats_2 { get; set; }
        public decimal Oplagskontingent_knæk { get; set; }
        public string Oplagskontingent_konto { get; set; }
    }
}
