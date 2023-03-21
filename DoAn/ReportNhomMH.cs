using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.Model;
using Microsoft.Reporting.WinForms;
namespace DoAn
{
    public partial class ReportNhomMH : Form
    {
        DbContentSinhVien dbSinhVien = new DbContentSinhVien();
        public ReportNhomMH()
        {
            InitializeComponent();
        }
       
        private void ReportNhomMH_Load(object sender, EventArgs e)
        {
            List<MaNhomHoc> listMaNhom = dbSinhVien.MaNhomHoc.ToList();
            FillDataCBBMaNhom(listMaNhom);
            FillDataCBBMaMon(listMaNhom);
            this.reportViewer1.RefreshReport();
            
        }
        private void FillDataCBBMaMon(List<MaNhomHoc> listNhomHoc)
        {
            cbbMaMonHoc.DataSource = listNhomHoc;
            cbbMaMonHoc.DisplayMember = "MaMon";
            cbbMaMonHoc.ValueMember = "MaMon";
        }
        private void FillDataCBBMaNhom(List<MaNhomHoc> listNhomHoc)
        {
            cbbMaNhom.DataSource = listNhomHoc;
            cbbMaNhom.DisplayMember = "MaNhom";
            cbbMaNhom.ValueMember = "MaNhom";
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cbbMaMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            List<MaNhomHoc> mhnReports = new List<MaNhomHoc>();
            List<SinhVien> studentReports = new List<SinhVien>();
            var manhomhoc = (from x in dbSinhVien.MaNhomHoc
                             from t in dbSinhVien.SVDangKiMonHoc
                             from u in dbSinhVien.SinhVien
                             from y in dbSinhVien.MonHoc
                             where
                                (cbbMaNhom.Text.ToString() == "" || x.MaNhom.CompareTo(cbbMaNhom.Text.ToString()) == 0)
                             && (x.MaMon == y.MaMon) && (t.MaMon == x.MaMon) && (t.MSSV == u.MSSV)
                             // kiem theo ma   // khoa
                             select new
                             {
                                 MaMon = x.MaMon,
                                 MaNhom = x.MaNhom,
                                 Thu = x.Thu,
                                 TietBatDau = x.TietBatDau,
                                 NgayBD = x.NgayBatDau,
                                 NgayKT = x.NgayKetThuc,
                                 MaGV = x.MaGiangVien,
                             }
             ).Distinct().ToList();
            var sv = (from x in dbSinhVien.MaNhomHoc
                             from t in dbSinhVien.SVDangKiMonHoc
                             from u in dbSinhVien.SinhVien
                             from y in dbSinhVien.MonHoc
                             where
                                (cbbMaNhom.Text.ToString() == "" || x.MaNhom.CompareTo(cbbMaNhom.Text.ToString()) == 0)
                             && (x.MaMon == y.MaMon) && (t.MaMon == x.MaMon) && (t.MSSV == u.MSSV)
                             // kiem theo ma   // khoa
                             select new
                             {
            
                                 MaSV = u.MSSV,
                                 HoSV = u.Ho,
                                 TenSV = u.Ten,
                                 NamSinhSV = u.NamSinh,
                                 CCCD_SV = u.CCCD,
                                 DanTocSV = u.DanToc,
                                 GioiTinhSV = u.GioiTinh,
                                 EmailSV = u.Email,
                                 SDT_SV = u.SDT,
                                 MaLop = u.MaLop,
                             }
            ).Distinct().ToList();
            foreach (var item in manhomhoc)
            {
                MaNhomHoc mnhReport = new MaNhomHoc();
                mnhReport.MaNhom = item.MaNhom;
                mnhReport.MaMon = item.MaMon;
                mnhReport.Thu = item.Thu;
                mnhReport.TietBatDau = item.TietBatDau;
                mnhReport.NgayBatDau = item.NgayBD;
                mnhReport.NgayKetThuc = item.NgayKT;
                mnhReport.MaGiangVien = item.MaGV;
                mhnReports.Add(mnhReport);
            }    
            foreach (var item in sv)
            {
                SinhVien studentReport = new SinhVien();           
                studentReport.MSSV = item.MaSV;
                studentReport.Ho = item.HoSV;
                studentReport.Ten = item.TenSV;
                studentReport.NamSinh = (DateTime)item.NamSinhSV;
                studentReport.CCCD = item.CCCD_SV;
                studentReport.DanToc = item.DanTocSV;
                studentReport.GioiTinh = item.GioiTinhSV;
                studentReport.Email = item.EmailSV;
                studentReport.SDT = item.SDT_SV;
                studentReport.MaLop = item.MaLop;
                studentReports.Add(studentReport);
            }
            //if (mmh == null || mnh == null || mamonhoc.Count == 0 || manhomhoc.Count == 0)
            //{
            //    MessageBox.Show("Không tìm thấy thông tin nhóm học ");
            //    return;
            //}
            this.reportViewer1.LocalReport.ReportPath = "ReportNhomMH.rdlc";
            var reportDataSource = new ReportDataSource("DataSetNhomMH", mhnReports);
            var reportDataSource1 = new ReportDataSource("DataSetSinhVienNhomMH", studentReports);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            //this.reportViewer1.LocalReport.DisplayName = "DANH SÁCH SINH VIÊN THEO LỚP";
            this.reportViewer1.RefreshReport();
        }
    }
}
