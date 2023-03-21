using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.Model;
using Microsoft.Reporting.WinForms;

namespace DoAn
{
    public partial class ReportSVKhoa : Form
    {
        DbContentSinhVien dbSinhVien = new DbContentSinhVien();
        public ReportSVKhoa()
        {
            InitializeComponent();
        }

        private void ReportSVKhoa_Load(object sender, EventArgs e)
        {
            List<Khoa> listKhoa = dbSinhVien.Khoa.ToList();
            FillDataCBB(listKhoa);
            this.reportViewer1.RefreshReport();
        }
        private void FillDataCBB(List<Khoa> listKhoa)
        {
            cbbMaKhoa.DataSource = listKhoa;
            cbbMaKhoa.DisplayMember = "TenKhoa";
            cbbMaKhoa.ValueMember = "TenKhoa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Khoa> listKhoa = dbSinhVien.Khoa.ToList();
            List<StudentReport> studentReports = new List<StudentReport>();
            var newlistSV = (from x in dbSinhVien.SinhVien
                             from z in dbSinhVien.Lop
                             from y in dbSinhVien.Khoa
                             where                            
                                (y.TenKhoa==cbbMaKhoa.Text.ToString())
                             && x.MaLop == z.MaLop && z.MaKhoa == y.MaKhoa
                             select new
                             {
                                 MaSV = x.MSSV,
                                 HoSV = x.Ho,
                                 TenSV = x.Ten,
                                 NamSinhSV = x.NamSinh,
                                 CCCD_SV = x.CCCD,
                                 DanTocSV = x.DanToc,
                                 GioiTinhSV = x.GioiTinh,
                                 EmailSV = x.Email,
                                 SDT_SV = x.SDT,
                                 TT_SV = x.TrangThai,
                                 MaLop = x.MaLop,
                                 TenKhoa = y.TenKhoa
                             }
                             ).Distinct().ToList();
            foreach (var item in newlistSV)
            {
                StudentReport studentReport = new StudentReport();

                studentReport.MSSV = item.MaSV;
                studentReport.Ho = item.HoSV;
                studentReport.Ten = item.TenSV;
                studentReport.NamSinh = (DateTime)item.NamSinhSV;
                studentReport.CCCD = item.CCCD_SV;
                studentReport.Dantoc = item.DanTocSV;

                studentReport.GioiTinh = item.GioiTinhSV;

                studentReport.Email = item.EmailSV;
                studentReport.SDT = item.SDT_SV;
                studentReport.TrangThai = item.TT_SV;
                studentReport.MaLop = item.MaLop;
                studentReport.TenKhoa = item.TenKhoa;

                studentReports.Add(studentReport);
            }

            this.reportViewer1.LocalReport.ReportPath = "ReportSVKhoa.rdlc";
            var reportDataSource = new ReportDataSource("DataSetSVKhoa", studentReports);
            var reportDataSource1 = new ReportDataSource("DataSetKhoa", studentReports);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            //this.reportViewer1.LocalReport.DisplayName = "DANH SÁCH SINH VIÊN THEO LỚP";
            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void StudentReportBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
