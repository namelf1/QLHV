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
    
    public partial class khoahoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public khoahoc()
        {
            this.lophocs = new HashSet<lophoc>();
        }
    
        public int id_khoahoc { get; set; }
        public string tenkhoahoc { get; set; }
        public string mota { get; set; }
        public string trinhdo { get; set; }
        public int sotuan { get; set; }
        public decimal hocphi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lophoc> lophocs { get; set; }
    }
}
