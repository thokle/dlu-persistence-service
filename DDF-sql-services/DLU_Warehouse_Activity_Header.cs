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
    
    public partial class DLU_Warehouse_Activity_Header
    {
        public byte[] timestamp { get; set; }
        public int Type { get; set; }
        public string No_ { get; set; }
        public string Location_Code { get; set; }
        public string Assigned_User_ID { get; set; }
        public System.DateTime Assignment_Date { get; set; }
        public System.DateTime Assignment_Time { get; set; }
        public int Sorting_Method { get; set; }
        public string No__Series { get; set; }
        public int No__Printed { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Registering_No_ { get; set; }
        public string Last_Registering_No_ { get; set; }
        public string Registering_No__Series { get; set; }
        public System.DateTime Date_of_Last_Printing { get; set; }
        public System.DateTime Time_of_Last_Printing { get; set; }
        public byte Breakbulk_Filter { get; set; }
        public string Source_No_ { get; set; }
        public int Source_Document { get; set; }
        public int Source_Type { get; set; }
        public int Source_Subtype { get; set; }
        public int Destination_Type { get; set; }
        public string Destination_No_ { get; set; }
        public string External_Document_No_ { get; set; }
        public System.DateTime Expected_Receipt_Date { get; set; }
        public System.DateTime Shipment_Date { get; set; }
        public string External_Document_No_2 { get; set; }
    }
}
