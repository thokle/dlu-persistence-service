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
    
    public partial class DLU_Pmt__Meth__Bank_Bookk__Central
    {
        public byte[] timestamp { get; set; }
        public string Payment_Method { get; set; }
        public string Bank_Bookkeeping_Branch_Code { get; set; }
        public int Maximum_No__of_Advice_Lines { get; set; }
        public string Method { get; set; }
        public string Channel { get; set; }
        public string Channel_2 { get; set; }
        public System.DateTime Payment_Allowed_From { get; set; }
        public System.DateTime Payment_Allowed_To { get; set; }
        public string Description { get; set; }
        public string Latest_Payment_Date_Calc_ { get; set; }
        public int Alternate_Advice_Line_Length { get; set; }
    }
}