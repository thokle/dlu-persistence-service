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
    
    public partial class DLU_Inbound_Product_Catalog_Line
    {
        public byte[] timestamp { get; set; }
        public int Inbound_Document_No_ { get; set; }
        public int Line_No_ { get; set; }
        public string No_ { get; set; }
        public string No__2 { get; set; }
        public string Description { get; set; }
        public string Search_Description { get; set; }
        public string Description_2 { get; set; }
        public byte Bill_of_Materials { get; set; }
        public string Class { get; set; }
        public string Base_Unit_of_Measure { get; set; }
        public int Price_Unit_Conversion { get; set; }
        public string Inventory_Posting_Group { get; set; }
        public string Shelf_No_ { get; set; }
        public string Sales_Qty__Disc__Code { get; set; }
        public string Item_Cust__Disc__Gr_ { get; set; }
        public byte Allow_Invoice_Disc_ { get; set; }
        public int Statistics_Group { get; set; }
        public int Commission_Group { get; set; }
        public decimal Unit_Price { get; set; }
        public int Price_Profit_Calculation { get; set; }
        public decimal Profit__ { get; set; }
        public int Costing_Method { get; set; }
        public decimal Unit_Cost { get; set; }
        public decimal Standard_Cost { get; set; }
        public decimal Last_Direct_Cost { get; set; }
        public decimal Average_Cost { get; set; }
        public decimal Minimum_Unit_Price { get; set; }
        public decimal Indirect_Cost__ { get; set; }
        public string Vendor_No_ { get; set; }
        public string Vendor_Item_No_ { get; set; }
        public string Lead_Time_Calculation { get; set; }
        public decimal Reorder_Point { get; set; }
        public decimal Maximum_Inventory { get; set; }
        public decimal Reorder_Quantity { get; set; }
        public string Alternative_Item_No_ { get; set; }
        public decimal Unit_List_Price { get; set; }
        public decimal Duty_Due__ { get; set; }
        public string Duty_Code { get; set; }
        public decimal Gross_Weight { get; set; }
        public decimal Net_Weight { get; set; }
        public decimal Units_per_Parcel { get; set; }
        public decimal Unit_Volume { get; set; }
        public string Durability { get; set; }
        public string Freight_Type { get; set; }
        public string Tariff_No_ { get; set; }
        public decimal Duty_Unit_Conversion { get; set; }
        public string Country_Purchased_Code { get; set; }
        public decimal Budget_Quantity { get; set; }
        public decimal Budgeted_Amount { get; set; }
        public decimal Budget_Profit { get; set; }
        public byte Comment { get; set; }
        public byte Blocked { get; set; }
        public System.DateTime Last_Date_Modified { get; set; }
        public System.DateTime Date_Filter { get; set; }
        public string Department_Filter { get; set; }
        public string Project_Filter { get; set; }
        public string Location_Filter { get; set; }
        public decimal Inventory { get; set; }
        public decimal Net_Invoiced_Qty_ { get; set; }
        public decimal Net_Change { get; set; }
        public decimal Purchases__Qty__ { get; set; }
        public decimal Sales__Qty__ { get; set; }
        public decimal Positive_Adjmt___Qty__ { get; set; }
        public decimal Negative_Adjmt___Qty__ { get; set; }
        public decimal Purchases__LCY_ { get; set; }
        public decimal Sales__LCY_ { get; set; }
        public decimal Positive_Adjmt___LCY_ { get; set; }
        public decimal Negative_Adjmt___LCY_ { get; set; }
        public decimal COGS__LCY_ { get; set; }
        public decimal Qty__on_Purch__Order { get; set; }
        public decimal Qty__on_Sales_Order { get; set; }
        public byte Price_Includes_VAT { get; set; }
        public byte Drop_Shipment_Filter { get; set; }
        public string VAT_Bus__Posting_Gr___Price_ { get; set; }
        public string Gen__Prod__Posting_Group { get; set; }
        public byte[] Picture { get; set; }
        public decimal Transferred__Qty__ { get; set; }
        public decimal Transferred__LCY_ { get; set; }
        public string Country_of_Origin_Code { get; set; }
        public byte Automatic_Ext__Texts { get; set; }
        public string No__Series { get; set; }
        public string Tax_Group_Code { get; set; }
        public string VAT_Prod__Posting_Group { get; set; }
        public int Reserve { get; set; }
        public decimal Reserved_Qty__on_Inventory { get; set; }
        public decimal Reserved_Qty__on_Purch__Orders { get; set; }
        public decimal Reserved_Qty__on_Sales_Orders { get; set; }
        public decimal Add__Curr__Average_Cost { get; set; }
        public int Low_Level_Code { get; set; }
        public decimal Lot_Size { get; set; }
        public string Serial_Nos_ { get; set; }
        public System.DateTime Last_Unit_Cost_Calc__Date { get; set; }
        public decimal Material_Cost_per_Unit { get; set; }
        public decimal Labor_Cost_per_Unit { get; set; }
        public decimal Indirect_Cost_per_Unit { get; set; }
        public decimal Scrap__ { get; set; }
        public string Requisition_Method_Code { get; set; }
        public byte Inventory_Value_Zero { get; set; }
        public int Discrete_Order_Quantity { get; set; }
        public decimal Minimum_Order_Quantity { get; set; }
        public decimal Maximum_Order_Quantity { get; set; }
        public decimal Inventory_Buffer_Quantity { get; set; }
        public decimal Order_Multiple { get; set; }
        public string Safety_Lead_Time { get; set; }
        public int Flushing_Method { get; set; }
        public int Requisition_System { get; set; }
        public decimal Scheduled_Receipt__Qty__ { get; set; }
        public decimal Scheduled_Need__Qty__ { get; set; }
        public decimal Rounding_Precision { get; set; }
        public string Sales_Unit_of_Measure { get; set; }
        public string Purch__Unit_of_Measure { get; set; }
        public string Reorder_Cycle { get; set; }
        public decimal Res__Qty__on_Prod__Order_Comp_ { get; set; }
        public byte Item_Imported { get; set; }
        public string Common_Item_No_ { get; set; }
        public decimal Qty__per_Unit_of_Measure { get; set; }
        public System.DateTime Starting_Date { get; set; }
        public string Currency_Code { get; set; }
    }
}