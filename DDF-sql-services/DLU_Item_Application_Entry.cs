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
    
    public partial class DLU_Item_Application_Entry
    {
        public byte[] timestamp { get; set; }
        public int Entry_No_ { get; set; }
        public int Item_Ledger_Entry_No_ { get; set; }
        public int Inbound_Item_Entry_No_ { get; set; }
        public int Outbound_Item_Entry_No_ { get; set; }
        public decimal Quantity { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public int Transferred_from_Entry_No_ { get; set; }
        public byte Cost_Application { get; set; }
        public System.DateTime Output_Completely_Invd__Date { get; set; }
    }
}
