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
    
    public partial class Å99___dlu_Depreciation_Book
    {
        public byte[] timestamp { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public byte G_L_Integration___Acq__Cost { get; set; }
        public byte G_L_Integration___Depreciation { get; set; }
        public byte G_L_Integration___Write_Down { get; set; }
        public byte G_L_Integration___Appreciation { get; set; }
        public byte G_L_Integration___Custom_1 { get; set; }
        public byte G_L_Integration___Custom_2 { get; set; }
        public byte G_L_Integration___Disposal { get; set; }
        public byte G_L_Integration___Maintenance { get; set; }
        public int Disposal_Calculation_Method { get; set; }
        public byte Use_Custom_1_Depreciation { get; set; }
        public byte Allow_Depr__below_Zero { get; set; }
        public byte Use_FA_Exch__Rate_in_Duplic_ { get; set; }
        public byte Part_of_Duplication_List { get; set; }
        public System.DateTime Last_Date_Modified { get; set; }
        public byte Allow_Indexation { get; set; }
        public byte Use_Same_FA_G_L_Posting_Dates { get; set; }
        public decimal Default_Exchange_Rate { get; set; }
        public byte Use_FA_Ledger_Check { get; set; }
        public byte Use_Rounding_in_Periodic_Depr_ { get; set; }
        public System.DateTime New_Fiscal_Year_Starting_Date { get; set; }
        public int No__of_Days_in_Fiscal_Year { get; set; }
        public byte Allow_Changes_in_Depr__Fields { get; set; }
        public decimal Default_Final_Rounding_Amount { get; set; }
        public decimal Default_Ending_Book_Value { get; set; }
        public int Periodic_Depr__Date_Calc_ { get; set; }
        public byte Mark_Errors_as_Corrections { get; set; }
        public byte Add_Curr_Exch_Rate___Acq__Cost { get; set; }
        public byte Add__Curr__Exch__Rate___Depr_ { get; set; }
        public byte Add_Curr_Exch_Rate__Write_Down { get; set; }
        public byte Add_Curr__Exch__Rate___Apprec_ { get; set; }
        public byte Add_Curr__Exch_Rate___Custom_1 { get; set; }
        public byte Add_Curr__Exch_Rate___Custom_2 { get; set; }
        public byte Add__Curr__Exch__Rate___Disp_ { get; set; }
        public byte Add__Curr__Exch__Rate___Maint_ { get; set; }
        public byte Use_Default_Dimension { get; set; }
        public byte Subtract_Disc__in_Purch__Inv_ { get; set; }
        public byte Allow_Correction_of_Disposal { get; set; }
        public byte Allow_more_than_360_Depr__Days { get; set; }
        public byte VAT_on_Net_Disposal_Entries { get; set; }
        public byte Allow_Acq__Cost_below_Zero { get; set; }
    }
}
