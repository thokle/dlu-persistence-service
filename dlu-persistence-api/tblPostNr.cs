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
    
    public partial class tblPostNr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPostNr()
        {
            this.tblBladStamdatas = new HashSet<tblBladStamdata>();
            this.tblKonkurrentDækning = new HashSet<tblKonkurrentDækning>();
            this.tblPostNrSøgning = new HashSet<tblPostNrSøgning>();
        }
    
        public int PostNr { get; set; }
        public string PostBy { get; set; }
        public int Husstande { get; set; }
        public byte MaxDækningsGrad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBladStamdata> tblBladStamdatas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKonkurrentDækning> tblKonkurrentDækning { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPostNrSøgning> tblPostNrSøgning { get; set; }
    }
}
