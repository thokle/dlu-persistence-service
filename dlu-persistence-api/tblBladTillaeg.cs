//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dlu_persistence_api
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBladTillaeg
    {
        public int id { get; set; }
        public Nullable<int> bladId { get; set; }
        public Nullable<int> typeId { get; set; }
        public Nullable<double> pris { get; set; }
        public Nullable<bool> mmpris { get; set; }
        public Nullable<bool> fastpris { get; set; }
        public Nullable<decimal> sum { get; set; }
    
        public virtual tblBladStamdata tblBladStamdata { get; set; }
        public virtual tblBladTillaegsType tblBladTillaegsType { get; set; }
    }
}
