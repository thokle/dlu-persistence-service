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
    
    public partial class tblPrislisterPrBladPrUge
    {
        public int BladID { get; set; }
        public byte Uge { get; set; }
        public short År { get; set; }
        public int PrislisteID { get; set; }
    
        public virtual tblBladStamdata tblBladStamdata { get; set; }
        public virtual tblPrislister tblPrislister { get; set; }
    }
}
