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
    
    public partial class DLU_Profile_Questionnaire_Line
    {
        public byte[] timestamp { get; set; }
        public string Profile_Questionnaire_Code { get; set; }
        public int Line_No_ { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public byte Multiple_Answers { get; set; }
        public byte Auto_Contact_Classification { get; set; }
        public int Customer_Class__Field { get; set; }
        public int Vendor_Class__Field { get; set; }
        public int Contact_Class__Field { get; set; }
        public string Starting_Date_Formula { get; set; }
        public string Ending_Date_Formula { get; set; }
        public int Classification_Method { get; set; }
        public int Sorting_Method { get; set; }
        public decimal From_Value { get; set; }
        public decimal To_Value { get; set; }
        public int Priority { get; set; }
        public int No__of_Decimals { get; set; }
        public decimal Min____Questions_Answered { get; set; }
    }
}
