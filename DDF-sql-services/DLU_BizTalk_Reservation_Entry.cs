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
    
    public partial class DLU_BizTalk_Reservation_Entry
    {
        public byte[] timestamp { get; set; }
        public int BizTalk_Document_No_ { get; set; }
        public int Biztalk_Document_Direction { get; set; }
        public int Source_Type { get; set; }
        public int BizTalk_Document_Line_No_ { get; set; }
        public int Entry_No_ { get; set; }
        public byte Positive { get; set; }
        public string Item_No_ { get; set; }
        public string Location_Code { get; set; }
        public decimal Quantity__Base_ { get; set; }
        public int Reservation_Status { get; set; }
        public string Description { get; set; }
        public System.DateTime Creation_Date { get; set; }
        public int Transferred_from_Entry_No_ { get; set; }
        public int Source_Subtype { get; set; }
        public string Source_ID { get; set; }
        public string Source_Batch_Name { get; set; }
        public int Source_Prod__Order_Line { get; set; }
        public int Source_Ref__No_ { get; set; }
        public int Appl__to_Item_Entry { get; set; }
        public System.DateTime Expected_Receipt_Date { get; set; }
        public System.DateTime Shipment_Date { get; set; }
        public string Serial_No_ { get; set; }
        public string Created_By { get; set; }
        public string Changed_By { get; set; }
        public decimal Qty__per_Unit_of_Measure { get; set; }
        public decimal Quantity { get; set; }
        public int Binding { get; set; }
        public byte Suppressed_Action_Msg_ { get; set; }
        public int Planning_Flexibility { get; set; }
        public System.DateTime Warranty_Date { get; set; }
        public System.DateTime Expiration_Date { get; set; }
        public decimal Qty__to_Handle__Base_ { get; set; }
        public decimal Qty__to_Invoice__Base_ { get; set; }
        public decimal Quantity_Invoiced__Base_ { get; set; }
        public string New_Serial_No_ { get; set; }
        public string New_Lot_No_ { get; set; }
        public string Lot_No_ { get; set; }
        public string Variant_Code { get; set; }
        public string Bin_Code { get; set; }
    }
}
