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
    
    public partial class DLU_Outbound_Purch__Document_Hdr_
    {
        public byte[] timestamp { get; set; }
        public int Outbound_Document_No_ { get; set; }
        public int Document_Type { get; set; }
        public string Buy_from_Vendor_No_ { get; set; }
        public string No_ { get; set; }
        public string Pay_to_Vendor_No_ { get; set; }
        public string Pay_to_Name { get; set; }
        public string Pay_to_Name_2 { get; set; }
        public string Pay_to_Address { get; set; }
        public string Pay_to_Address_2 { get; set; }
        public string Pay_to_City { get; set; }
        public string Pay_to_Contact { get; set; }
        public string Your_Reference { get; set; }
        public string Ship_to_Code { get; set; }
        public string Ship_to_Name { get; set; }
        public string Ship_to_Name_2 { get; set; }
        public string Ship_to_Address { get; set; }
        public string Ship_to_Address_2 { get; set; }
        public string Ship_to_City { get; set; }
        public string Ship_to_Contact { get; set; }
        public System.DateTime Order_Date { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public System.DateTime Expected_Receipt_Date { get; set; }
        public string Posting_Description { get; set; }
        public string Payment_Terms_Code { get; set; }
        public System.DateTime Due_Date { get; set; }
        public decimal Payment_Discount__ { get; set; }
        public System.DateTime Pmt__Discount_Date { get; set; }
        public string Shipment_Method_Code { get; set; }
        public string Location_Code { get; set; }
        public string Shortcut_Dimension_1_Code { get; set; }
        public string Shortcut_Dimension_2_Code { get; set; }
        public string Vendor_Posting_Group { get; set; }
        public string Currency_Code { get; set; }
        public decimal Currency_Factor { get; set; }
        public string Invoice_Disc__Code { get; set; }
        public string Language_Code { get; set; }
        public string Purchaser_Code { get; set; }
        public string Order_Class { get; set; }
        public byte Comment { get; set; }
        public int No__Printed { get; set; }
        public string On_Hold { get; set; }
        public int Applies_to_Doc__Type { get; set; }
        public string Applies_to_Doc__No_ { get; set; }
        public string Bal__Account_No_ { get; set; }
        public string Job_No_ { get; set; }
        public byte Receive { get; set; }
        public byte Invoice { get; set; }
        public decimal Amount { get; set; }
        public decimal Amount_Including_VAT { get; set; }
        public string Receiving_No_ { get; set; }
        public string Posting_No_ { get; set; }
        public string Last_Receiving_No_ { get; set; }
        public string Last_Posting_No_ { get; set; }
        public string Vendor_Order_No_ { get; set; }
        public string Vendor_Shipment_No_ { get; set; }
        public string Vendor_Invoice_No_ { get; set; }
        public string Vendor_Cr__Memo_No_ { get; set; }
        public string VAT_Registration_No_ { get; set; }
        public string Sell_to_Customer_No_ { get; set; }
        public string Reason_Code { get; set; }
        public string Gen__Bus__Posting_Group { get; set; }
        public string Transaction_Type { get; set; }
        public string Transport_Method { get; set; }
        public string VAT_Country_Code { get; set; }
        public string Buy_from_Vendor_Name { get; set; }
        public string Buy_from_Vendor_Name_2 { get; set; }
        public string Buy_from_Address { get; set; }
        public string Buy_from_Address_2 { get; set; }
        public string Buy_from_City { get; set; }
        public string Buy_from_Contact { get; set; }
        public string Pay_to_Post_Code { get; set; }
        public string Pay_to_County { get; set; }
        public string Pay_to_Country_Code { get; set; }
        public string Buy_from_Post_Code { get; set; }
        public string Buy_from_County { get; set; }
        public string Buy_from_Country_Code { get; set; }
        public string Ship_to_Post_Code { get; set; }
        public string Ship_to_County { get; set; }
        public string Ship_to_Country_Code { get; set; }
        public int Bal__Account_Type { get; set; }
        public string Order_Address_Code { get; set; }
        public string Entry_Point { get; set; }
        public byte Correction { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Area { get; set; }
        public string Transaction_Specification { get; set; }
        public string Payment_Method_Code { get; set; }
        public string No__Series { get; set; }
        public string Posting_No__Series { get; set; }
        public string Receiving_No__Series { get; set; }
        public string Tax_Area_Code { get; set; }
        public byte Tax_Liable { get; set; }
        public string VAT_Bus__Posting_Group { get; set; }
        public string Applies_to_ID { get; set; }
        public decimal VAT_Base_Discount__ { get; set; }
        public System.DateTime Date_Sent { get; set; }
        public System.DateTime Time_Sent { get; set; }
        public int Status { get; set; }
        public string Tracking_ID { get; set; }
        public int No__Resent { get; set; }
        public int BizTalk_Document_Type { get; set; }
        public string Customer_Quote_No_ { get; set; }
        public string Customer_Order_No_ { get; set; }
        public string Vendor_Quote_No_ { get; set; }
        public byte Document_Selected { get; set; }
    }
}