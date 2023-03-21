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
    public partial class ReportBXH : Form
    {
        DbContentSinhVien dbContent = new DbContentSinhVien();
        public ReportBXH()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"data source=DESKTOP-ER788FD;initial catalog=QLSV_CoSo;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;
        int j = 0;
        string sql;
        private void ReportBXH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQLDiem.Diem' table. You can move, or remove it, as needed.

            this.sinhVienTableAdapter.Fill(this.dataSetQLDiem.SinhVien);
            this.lopTableAdapter.Fill(this.dataSetQLDiem.Lop);
            this.khoaTableAdapter.Fill(this.dataSetQLDiem.Khoa);
            List<HocKy> listHocKy = dbContent.HocKy.ToList();
            ketnoi = new SqlConnection(chuoiketnoi);
            FillDataCBB_HocKi(listHocKy);

            cbbMaKhoa.SelectedIndex = -1;
            cbbHocKi.SelectedIndex = -1;
            this.reportViewer1.RefreshReport();
        }
        private void FillDataCBB_HocKi(List<HocKy> listHocKy)
        {
            cbbHocKi.DataSource = listHocKy;         // cbb hoc ky
            cbbHocKi.DisplayMember = "TenHocKy";
            cbbHocKi.ValueMember = "TenHocKy";
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            List<DiemReport> studentReports = new List<DiemReport>();
            var bxhTheoHocKy = (from x in dbContent.Diem
                             from y in dbContent.SinhVien
                             from z in dbContent.Lop
                             where(
                             (cbbMaKhoa.Text.ToString()==""||z.MaKhoa.Contains(cbbMaKhoa.Text.ToString()))
                             && (cbbMaLop.Text.ToString()==""||z.MaLop.Contains(cbbMaLop.Text.ToString()))
                            && (cbbHocKi.Text.ToString() == "" || x.HocKy.TenHocKy.Contains(cbbHocKi.Text.ToString()))
                             && x.MSSV == y.MSSV && y.MaLop ==z.MaLop
                             && x.LanThi == (
                                      from x1 in dbContent.Diem
                                      where x1.MSSV == x.MSSV
                                      && x1.MaMon == x.MaMon
                                      group x1 by new { x1.LanThi } into g1
                                      orderby g1.Key.LanThi descending
                                      select new
                                      {
                                          LanThiMax = g1.Key.LanThi
                                      }
                                  ).Max(p => p.LanThiMax))
                            group x by new { x.MSSV, y.MaLop, z.MaKhoa, } into g
                            orderby g.Average(p => p.DiemTongKet) descending
                                select new
                             {
                                MSSV = g.Key.MSSV,
                                MaLop = g.Key.MaLop,
                                MaKhoa = g.Key.MaKhoa,
                                DiemTb = g.Average(p => p.DiemTongKet)
                                }
             ).ToList();

            foreach (var item in bxhTheoHocKy)
            {
                DiemReport studentReport = new DiemReport();
                studentReport.MSSV = item.MSSV;
                studentReport.MaLop = item.MaLop;
                studentReport.DiemTongKet = item.DiemTb;

                studentReports.Add(studentReport);
            }

            this.reportViewer1.LocalReport.ReportPath = "ReportBXH.rdlc";
            var reportDataSource = new ReportDataSource("DataSetDiemSV", studentReports);
            var reportDataSource1 = new ReportDataSource("DataSetSV", studentReports);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

            //this.reportViewer1.LocalReport.DisplayName = "DANH SÁCH SINH VIÊN THEO LỚP";
            this.reportViewer1.RefreshReport();
        }

        private void cbbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbMaLop.Items.Clear();
            cbbMaLop.Text = null;
            cbbMaLop.SelectedIndex = -1;
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
    }
}
