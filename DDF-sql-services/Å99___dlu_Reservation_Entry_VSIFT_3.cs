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
    
    public partial class Å99___dlu_Reservation_Entry_VSIFT_3
    {
        public string Item_No_ { get; set; }
        public int Source_Type { get; set; }
        public int Source_Subtype { get; set; }
        public int Reservation_Status { get; set; }
        public string Location_Code { get; set; }
        public string Variant_Code { get; set; }
        public System.DateTime Shipment_Date { get; set; }
        public System.DateTime Expected_Receipt_Date { get; set; }
        public string Serial_No_ { get; set; }
        public string Lot_No_ { get; set; }
        public Nullable<long> C_Cnt { get; set; }
        public Nullable<decimal> SUM_Quantity__Base_ { get; set; }
        public Nullable<decimal> SUM_Quantity { get; set; }
        public Nullable<decimal> SUM_Reserved_Pick___Ship_Qty_ { get; set; }
    }
}
