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
    
    public partial class lophoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lophoc()
        {
            this.BaiKiemTras = new HashSet<BaiKiemTra>();
            this.DangKyhocs = new HashSet<DangKyhoc>();
            this.DiemDanhs = new HashSet<DiemDanh>();
        }
    
        public int id_lop { get; set; }
        public int id_khoahoc { get; set; }
        public int id_giaovien { get; set; }
        public string tenlop { get; set; }
        public System.DateTime ngaybatdau { get; set; }
        public System.DateTime ngayketthuc { get; set; }
        public string schedule { get; set; }
        public string phonghoc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiKiemTra> BaiKiemTras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyhoc> DangKyhocs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiemDanh> DiemDanhs { get; set; }
        public virtual giaovien giaovien { get; set; }
        public virtual khoahoc khoahoc { get; set; }
    }
}
