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
    
    public partial class DLU_VAT_Entry_VSIFT_2
    {
        public int Type { get; set; }
        public string Country_Code { get; set; }
        public string VAT_Registration_No_ { get; set; }
        public string VAT_Bus__Posting_Group { get; set; }
        public string VAT_Prod__Posting_Group { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public Nullable<long> C_Cnt { get; set; }
        public Nullable<decimal> SUM_Base { get; set; }
        public Nullable<decimal> SUM_Additional_Currency_Base { get; set; }
    }
}
