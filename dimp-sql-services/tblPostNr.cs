//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dimp_sql_services
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPostNr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPostNr()
        {
            this.tblDækning = new HashSet<tblDækning>();
        }
    
        public string PostNr { get; set; }
        public Nullable<short> ById { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDækning> tblDækning { get; set; }
        public virtual tblHusstande tblHusstande { get; set; }
    }
}