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
    
    public partial class Permission
    {
        public byte[] timestamp { get; set; }
        public string Role_ID { get; set; }
        public int Object_Type { get; set; }
        public int Object_ID { get; set; }
        public int Read_Permission { get; set; }
        public int Insert_Permission { get; set; }
        public int Modify_Permission { get; set; }
        public int Delete_Permission { get; set; }
        public int Execute_Permission { get; set; }
        public byte[] Security_Filter { get; set; }
    }
}
