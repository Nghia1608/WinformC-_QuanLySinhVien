namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(10)]
        public string MaGiangVien { get; set; }

        [StringLength(50)]
        public string Gmail { get; set; }

        [Required]
        [StringLength(10)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Quyen { get; set; }

        public virtual GiangVien GiangVien { get; set; }
    }
}
