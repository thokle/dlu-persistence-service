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
    
    public partial class Å99___dlu_Service_Order_Allocation_VSIFT_1
    {
        public int Status { get; set; }
        public int Document_Type { get; set; }
        public string Document_No_ { get; set; }
        public int Service_Item_Line_No_ { get; set; }
        public System.DateTime Allocation_Date { get; set; }
        public System.DateTime Starting_Time { get; set; }
        public byte Posted { get; set; }
        public Nullable<long> C_Cnt { get; set; }
        public Nullable<decimal> SUM_Allocated_Hours { get; set; }
    }
}
