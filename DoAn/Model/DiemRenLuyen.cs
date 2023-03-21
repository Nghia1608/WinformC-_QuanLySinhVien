namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiemRenLuyen")]
    public partial class DiemRenLuyen
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MSSV { get; set; }

        [Column("DiemRenLuyen")]
        public int? DiemRenLuyen1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string MaHocKy { get; set; }

        public virtual HocKy HocKy { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
