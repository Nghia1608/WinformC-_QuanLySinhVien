using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn.Model
{
    public partial class DbContentSinhVien : DbContext
    {
        public DbContentSinhVien()
            : base("name=DbContentSinhVien")
        {
        }

        public virtual DbSet<Diem> Diem { get; set; }
        public virtual DbSet<DiemRenLuyen> DiemRenLuyen { get; set; }
        public virtual DbSet<GiangVien> GiangVien { get; set; }
        public virtual DbSet<HocKy> HocKy { get; set; }
        public virtual DbSet<HocPhi> HocPhi { get; set; }
        public virtual DbSet<Khoa> Khoa { get; set; }
        public virtual DbSet<KhoaHoc> KhoaHoc { get; set; }
        public virtual DbSet<Lop> Lop { get; set; }
        public virtual DbSet<MaNhomHoc> MaNhomHoc { get; set; }
        public virtual DbSet<MonHoc> MonHoc { get; set; }
        public virtual DbSet<SinhVien> SinhVien { get; set; }
        public virtual DbSet<SVDangKiMonHoc> SVDangKiMonHoc { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<TotNghiep> TotNghiep { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diem>()
                .Property(e => e.MSSV)
                .IsUnicode(false);

            modelBuilder.Entity<Diem>()
                .Property(e => e.MaMon)
                .IsUnicode(false);

            modelBuilder.Entity<Diem>()
                .Property(e => e.DiemChu)
                .IsUnicode(false);

            modelBuilder.Entity<Diem>()
                .Property(e => e.MaHocKy)
                .IsUnicode(false);

            modelBuilder.Entity<DiemRenLuyen>()
                .Property(e => e.MSSV)
                .IsUnicode(false);

            modelBuilder.Entity<DiemRenLuyen>()
                .Property(e => e.MaHocKy)
                .IsUnicode(false);

            modelBuilder.Entity<GiangVien>()
                .Property(e => e.MaGiangVien)
                .IsUnicode(false);

            modelBuilder.Entity<GiangVien>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GiangVien>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<HocKy>()
                .Property(e => e.MaHocKy)
                .IsUnicode(false);

            modelBuilder.Entity<HocKy>()
                .HasMany(e => e.DiemRenLuyens)
                .WithRequired(e => e.HocKy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HocPhi>()
                .Property(e => e.MaHocPhi)
                .IsUnicode(false);


            modelBuilder.Entity<HocPhi>()
                .Property(e => e.MSSV)
                .IsUnicode(false);

            modelBuilder.Entity<HocPhi>()
                .Property(e => e.MaHocKy)
                .IsUnicode(false);

            modelBuilder.Entity<Khoa>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<KhoaHoc>()
                .Property(e => e.MaKhoaHoc)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.MaKhoaHoc)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<MaNhomHoc>()
                .Property(e => e.MaMon)
                .IsUnicode(false);

            modelBuilder.Entity<MaNhomHoc>()
                .Property(e => e.MaNhom)
                .IsUnicode(false);

            modelBuilder.Entity<MaNhomHoc>()
                .Property(e => e.MaGiangVien)
                .IsUnicode(false);

            modelBuilder.Entity<MaNhomHoc>()
                .HasMany(e => e.SVDangKiMonHocs)
                .WithRequired(e => e.MaNhomHoc)
                .HasForeignKey(e => new { e.MaMon, e.MaNhom })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.MaMon)
                .IsUnicode(false);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.Diems)
                .WithRequired(e => e.MonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.MaNhomHocs)
                .WithRequired(e => e.MonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.SVDangKiMonHocs)
                .WithRequired(e => e.MonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MSSV)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.Diems)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.DiemRenLuyens)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.HocPhis)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.SVDangKiMonHocs)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SVDangKiMonHoc>()
                .Property(e => e.MSSV)
                .IsUnicode(false);

            modelBuilder.Entity<SVDangKiMonHoc>()
                .Property(e => e.MaMon)
                .IsUnicode(false);

            modelBuilder.Entity<SVDangKiMonHoc>()
                .Property(e => e.MaNhom)
                .IsUnicode(false);

            modelBuilder.Entity<SVDangKiMonHoc>()
                .Property(e => e.MaHocKy)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MaGiangVien)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Quyen)
                .IsUnicode(false);
            modelBuilder.Entity<TotNghiep>()
               .Property(e => e.MSSV)
               .IsUnicode(false);

            modelBuilder.Entity<TotNghiep>()
                .Property(e => e.XepLoai)
                .IsUnicode(false);

        }
    }
}
