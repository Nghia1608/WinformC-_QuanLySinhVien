namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaNhomHoc")]
    public partial class MaNhomHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MaNhomHoc()
        {
            SVDangKiMonHocs = new HashSet<SVDangKiMonHoc>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string MaMon { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string MaNhom { get; set; }

        public int? Thu { get; set; }
        public int TietBatDau { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayBatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        [StringLength(10)]
        public string MaGiangVien { get; set; }

        public virtual GiangVien GiangVien { get; set; }

        public virtual MonHoc MonHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SVDangKiMonHoc> SVDangKiMonHocs { get; set; }
    }
}
