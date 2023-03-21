namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiangVien")]
    public partial class GiangVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiangVien()
        {
            MaNhomHocs = new HashSet<MaNhomHoc>();
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        [Key]
        [StringLength(10)]
        public string MaGiangVien { get; set; }

        [StringLength(6)]
        public string Ho { get; set; }

        [StringLength(30)]
        public string Ten { get; set; }

        [StringLength(10)]
        public string HocVi { get; set; }

        [StringLength(20)]
        public string ChuyenNganh { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        [StringLength(3)]
        public string MaKhoa { get; set; }

        public virtual Khoa Khoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaNhomHoc> MaNhomHocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
