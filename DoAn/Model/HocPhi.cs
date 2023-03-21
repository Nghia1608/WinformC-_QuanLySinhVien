namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocPhi")]
    public partial class HocPhi
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(16)]
        public string MaHocPhi { get; set; }


        public int SoTien { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MSSV { get; set; }

        [StringLength(6)]
        public string MaHocKy { get; set; }

        [StringLength(20)]
        public string TrangThai { get; set; }

        public virtual SinhVien SinhVien { get; set; }
        public virtual HocKy HocKy { get; set; }
    }
}
