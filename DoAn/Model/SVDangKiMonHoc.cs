namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SVDangKiMonHoc")]
    public partial class SVDangKiMonHoc
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MSSV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string MaMon { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string MaNhom { get; set; }

        [StringLength(6)]
        public string MaHocKy { get; set; }

        public virtual MaNhomHoc MaNhomHoc { get; set; }

        public virtual MonHoc MonHoc { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
