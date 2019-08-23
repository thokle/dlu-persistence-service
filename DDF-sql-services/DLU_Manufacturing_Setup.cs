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
    
    public partial class DLU_Manufacturing_Setup
    {
        public byte[] timestamp { get; set; }
        public string Primary_Key { get; set; }
        public System.DateTime Normal_Starting_Time { get; set; }
        public System.DateTime Normal_Ending_Time { get; set; }
        public byte Doc__No__Is_Prod__Order_No_ { get; set; }
        public byte Cost_Incl__Setup { get; set; }
        public byte Dynamic_Low_Level_Code { get; set; }
        public byte Planning_Warning { get; set; }
        public string Simulated_Order_Nos_ { get; set; }
        public string Planned_Order_Nos_ { get; set; }
        public string Firm_Planned_Order_Nos_ { get; set; }
        public string Released_Order_Nos_ { get; set; }
        public string Work_Center_Nos_ { get; set; }
        public string Machine_Center_Nos_ { get; set; }
        public string Production_BOM_Nos_ { get; set; }
        public string Routing_Nos_ { get; set; }
        public string Current_Production_Forecast { get; set; }
        public byte Use_Forecast_on_Locations { get; set; }
        public byte Combined_MPS_MRP_Calculation { get; set; }
        public string Components_at_Location { get; set; }
        public string Dampener__Time_ { get; set; }
        public decimal Dampener____of_Lot_Size_ { get; set; }
        public string Default_Safety_Lead_Time { get; set; }
        public int Preset_Output_Quantity { get; set; }
    }
}
