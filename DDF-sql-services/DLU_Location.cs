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
    
    public partial class DLU_Location
    {
        public byte[] timestamp { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Name_2 { get; set; }
        public string Address { get; set; }
        public string Address_2 { get; set; }
        public string City { get; set; }
        public string Phone_No_ { get; set; }
        public string Phone_No__2 { get; set; }
        public string Telex_No_ { get; set; }
        public string Fax_No_ { get; set; }
        public string Contact { get; set; }
        public string Post_Code { get; set; }
        public string County { get; set; }
        public string E_Mail { get; set; }
        public string Home_Page { get; set; }
        public string Country_Code { get; set; }
        public byte Use_As_In_Transit { get; set; }
        public byte Require_Put_away { get; set; }
        public byte Require_Pick { get; set; }
        public string Cross_Dock_Due_Date_Calc_ { get; set; }
        public byte Use_Cross_Docking { get; set; }
        public byte Require_Receive { get; set; }
        public byte Require_Shipment { get; set; }
        public byte Bin_Mandatory { get; set; }
        public byte Directed_Put_away_and_Pick { get; set; }
        public int Default_Bin_Selection { get; set; }
        public string Outbound_Whse__Handling_Time { get; set; }
        public string Inbound_Whse__Handling_Time { get; set; }
        public string Put_away_Template_Code { get; set; }
        public byte Use_Put_away_Worksheet { get; set; }
        public byte Allow_Breakbulk { get; set; }
        public int Bin_Capacity_Policy { get; set; }
        public string Open_Shop_Floor_Bin_Code { get; set; }
        public string Inbound_Production_Bin_Code { get; set; }
        public string Outbound_Production_Bin_Code { get; set; }
        public string Adjustment_Bin_Code { get; set; }
        public byte Always_Create_Put_away_Line { get; set; }
        public byte Always_Create_Pick_Line { get; set; }
        public int Special_Equipment { get; set; }
        public string Receipt_Bin_Code { get; set; }
        public string Shipment_Bin_Code { get; set; }
        public string Cross_Dock_Bin_Code { get; set; }
        public string Outbound_BOM_Bin_Code { get; set; }
        public string Inbound_BOM_Bin_Code { get; set; }
        public string Base_Calendar_Code { get; set; }
        public byte Use_ADCS { get; set; }
    }
}