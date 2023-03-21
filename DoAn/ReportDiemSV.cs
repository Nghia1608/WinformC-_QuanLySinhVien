using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Validation;
using DoAn.Model;
using Microsoft.Reporting.WinForms;

namespace DoAn
{
    public partial class ReportDiemSV : Form
    {
        DbContentSinhVien dbContent = new DbContentSinhVien();
        public ReportDiemSV()
        {
            InitializeComponent();
        }
        private void ReportDiemSV_Load(object sender, EventArgs e)
        {
            this.sinhVienTableAdapter.Fill(this.dataSetQLDiem.SinhVien);
            this.lopTableAdapter.Fill(this.dataSetQLDiem.Lop);
            this.khoaTableAdapter.Fill(this.dataSetQLDiem.Khoa);

            ketnoi = new SqlConnection(chuoiketnoi);
            cbbMaKhoa.SelectedIndex = -1;

            this.reportViewer1.RefreshReport();
        }

        string chuoiketnoi = @"data source=DESKTOP-ER788FD;initial catalog=QLSV_CoSo;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;
        int j = 0;
        string sql;
        private void cbbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbMaLop.Items.Clear();
            cbbMaLop.Text = null;
            cbbMaLop.SelectedIndex = -1;
            cbbMSSV.Items.Clear();
            cbbMSSV.SelectedIndex = -1;
            //    cbbMSSV.Text = null;
            ketnoi.Open();
            sql = @"Select Khoa.MaKhoa,Lop.MaLop
                    From    Khoa Join Lop
                    On Khoa.MaKhoa = Lop.MaKhoa
                    Where (Khoa.MaKhoa = N'" + cbbMaKhoa.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                cbbMaLop.Items.Add(docdulieu[1].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbMSSV.Items.Clear();
            cbbMSSV.SelectedIndex = -1;
            //    cbbMSSV.Text = null;
            ketnoi.Open();
            sql = @"Select Lop.MaLop,SinhVien.MSSV
                    From    Lop Join SinhVien
                    On Lop.MaLop = SinhVien.MaLop
                    Where (Lop.MaLop = N'" + cbbMaLop.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            j = 0;
            while (docdulieu.Read())
            {
                cbbMSSV.Items.Add(docdulieu[1].ToString());
                j++;
            }
            ketnoi.Close();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            List<DiemReport> studentReports = new List<DiemReport>();
            var newlistSV = (from x in dbContent.Diem
                             from u in dbContent.MonHoc
                             where
                             (x.MSSV == cbbMSSV.SelectedItem.ToString()
                             && x.MaMon == u.MaMon
                             //&& (x.HocKy.TenHocKy == cbbHocKi.SelectedValue.ToString())
                            )       // kiem theo ma   // khoa
                             select new
                             {
                                 MaMon1 = x.MaMon,
                                 LanThi1 = x.LanThi,
                                 DiemQuaTrinh1 = x.DiemQuaTrinh,
                                 DiemThi1 = x.DiemThi,
                                 DiemTongKet1 = x.DiemTongKet,
                                 DiemChu1 = x.DiemChu,
                                 KetQua1 = x.KetQua,
                                 TinhTrang1 = x.TinhTrang,
                                 MaHocKy1 = x.HocKy.TenHocKy,
                                 SoTinChi1 = u.SoTinChi,

                                 MSSV1 = x.MSSV,
                             }
             ).ToList();

            foreach (var item in newlistSV)
            {
                DiemReport studentReport = new DiemReport();
                studentReport.MaMon = item.MaMon1;
                studentReport.LanThi = item.LanThi1;
                studentReport.DiemQuaTrinh = item.DiemQuaTrinh1;
                studentReport.DiemThi = item.DiemThi1;
                studentReport.DiemTongKet = item.DiemTongKet1;
                studentReport.DiemChu = item.DiemChu1;
                studentReport.KetQua = item.KetQua1;
                studentReport.TinhTrang = item.TinhTrang1;
                studentReport.MaHocKy = item.MaHocKy1;
                studentReport.MSSV = item.MSSV1;
                studentReport.SoTinChi = item.SoTinChi1;

                studentReports.Add(studentReport);
            }

            this.reportViewer1.LocalReport.ReportPath = "ReportDiemSV.rdlc";
            var reportDataSource = new ReportDataSource("DataSetDiemSV", studentReports);
            var reportDataSource1 = new ReportDataSource("DataSetMon", studentReports);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

            //this.reportViewer1.LocalReport.DisplayName = "DANH SÁCH SINH VIÊN THEO LỚP";
            this.reportViewer1.RefreshReport();


        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void diemBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
