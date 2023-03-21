namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TotNghiep")]
    public partial class TotNghiep
    {
        [Key]
        [StringLength(10)]
        public string MSSV { get; set; }

        public int? SoTinChi { get; set; }

        public double? TongDiem { get; set; }

        [StringLength(10)]
        public string XepLoai { get; set; }
    }
}
