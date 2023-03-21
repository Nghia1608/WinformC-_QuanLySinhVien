namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonHoc")]
    public partial class MonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonHoc()
        {
            Diems = new HashSet<Diem>();
            MaNhomHocs = new HashSet<MaNhomHoc>();
            SVDangKiMonHocs = new HashSet<SVDangKiMonHoc>();
        }

        [Key]
        [StringLength(6)]
        public string MaMon { get; set; }

        [StringLength(30)]
        public string TenMon { get; set; }

        public int SoTiet { get; set; }

        public int SoTinChi { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diem> Diems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaNhomHoc> MaNhomHocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SVDangKiMonHoc> SVDangKiMonHocs { get; set; }
    }
}
