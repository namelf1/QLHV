//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class giaovien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public giaovien()
        {
            this.lophocs = new HashSet<lophoc>();
        }
    
        public int id_giaovien { get; set; }
        public string ten { get; set; }
        public System.DateTime ngaysinh { get; set; }
        public string email { get; set; }
        public string sdt { get; set; }
        public string diachi { get; set; }
        public System.DateTime hiring_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lophoc> lophocs { get; set; }
    }
}